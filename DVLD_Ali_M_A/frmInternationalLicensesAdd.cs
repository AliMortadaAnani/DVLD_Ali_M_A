using DVLD_Business;
using DVLD_General;
using Krypton.Toolkit;
using System.Runtime.CompilerServices;

namespace DVLD_Presentation
{
    public partial class frmInternationalLicensesAdd : frmGeneral
    {

        int LocalLicenseID = -1;
        int InternationalLicenseID = -1;
        int PersonID = -1;
        public frmInternationalLicensesAdd()
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Issue New International License";
            btnhistory.Enabled = false;
            btnlicenseinfo.Enabled = false;
            btnIntIssue.Enabled = false;
            ctrlApplicationShow1._LoadData_Int();
            
        }



        private void frmInternationalLicensesAdd_Load(object sender, EventArgs e)
        {

        }




        private void ctrlLicenseSearch1_OnLicenseSearchComplete(int obj)
        {
            LocalLicenseID = obj;
            ctrlLicenseInfo1._LicenseID = LocalLicenseID;
            ctrlLicenseInfo1._LoadData();
            ctrlApplicationShow1._LoadData_Int();
            PersonID = clsApplication.GetApplicationByID(clsLicense.GetLicense(obj).ApplicationID).ApplicantPersonID;
            ctrlApplicationShow1.lblnametxt.Text = clsPeople.Find(PersonID).FirstName + " " + clsPeople.Find(PersonID).LastName;

            

            btnIntIssue.Enabled = true;
            btnhistory.Enabled = true;

            if (clsInternationalLicense.IsInternationalLicenseExists(obj))
            {
                MessageBox.Show("International Driving License for this driver already exists.");
                btnIntIssue.Enabled = false;
                btnlicenseinfo.Enabled = true;
                
                InternationalLicenseID = clsInternationalLicense.GetInternationalLicenseIdByLocalLicenseID(LocalLicenseID);
                ctrlApplicationShow1._ApplicationID = clsInternationalLicense.GetLicense(InternationalLicenseID).ApplicationID;
                ctrlApplicationShow1._LoadData();

                return;
            }
          
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {

            int appid = clsLicense.GetLicense(LocalLicenseID).ApplicationID;
            int personid = clsApplication.GetApplicationByID(appid).ApplicantPersonID;
            frmShowLicenseHistory frm = new frmShowLicenseHistory(personid);
            frm.ShowDialog();
            ctrlLicenseInfo1._LoadData();
            ctrlApplicationShow1.lblnametxt.Text = clsPeople.Find(PersonID).FirstName + " " + clsPeople.Find(PersonID).LastName;
        }

        private void btnlicenseinfo_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseShowDetails frmInternationalLicenseShowDetails = new(InternationalLicenseID);
            frmInternationalLicenseShowDetails.ShowDialog();
        }

        private void btnIntIssue_Click(object sender, EventArgs e)
        {
            var license = clsLicense.GetLicense(LocalLicenseID);
            var application = clsApplication.GetApplicationByID(license.ApplicationID);


            if (clsLicense.GetAllInternationalLicensesByPersonID(PersonID).Rows.Count != 0)
            {
                MessageBox.Show(
                    $"International Driving License for this driver already exists.",
                    "International License Existed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    0,
                    false
                );
                return;
            }

            else if (license.ExpirationDate <= DateTime.Now)
            {
                MessageBox.Show(
                    $"The local license is expired.\n\n" +
                    $"Expiration Date: {license.ExpirationDate:d}\n\n" +
                    "An international license cannot be issued for an expired local license.",
                    "License Expired",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    0,
                    false
                );
                return;
            }
            else if (!license.IsActive)
            {
                MessageBox.Show(
                    "The local license is not active.\n\n" +
                    "You must reactivate it before issuing an international license.",
                    "License Inactive",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    0,
                    false
                );
                return;
            }
            else if (clsLicense.IsLicenseDetained(LocalLicenseID))
            {
                MessageBox.Show(
                    "The local license is detained.\n\n" +
                    "Issuing an international license is not allowed while it is in this status.",
                    "License Detained",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    0,
                    false
                );
                return;
            }
            else
            {
                // Get the required fee amount (replace 500 with your actual fee or get it from database)
                int licenseFee = Convert.ToInt32(clsApplicationType.GetByID((int)enApplicationType.International).Fees); // Or: clsLicense.GetLicenseFee(_LicenseID);

                // Show payment confirmation with specific amount
                DialogResult result = MessageBox.Show(
                    $"This license requires a fee of {licenseFee} USD. Do you want to proceed with payment?",
                    "Payment Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("Payment cancelled. License cannot be processed without payment.",
                                   "Payment Required",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    return;
                }



                clsApplication int_application = new();
                int_application.ApplicantPersonID = application.ApplicantPersonID;
                int_application.ApplicationTypeID = (int)enApplicationType.International;
                int_application.ApplicationStatus = enApplicationStatus.Completed;
                int_application.ApplicationDate = DateTime.Now;
                int_application.LastStatusDate = DateTime.Now;
                int_application.PaidFees = clsApplicationType.GetByID((int)enApplicationType.International).Fees;
                int_application.CreatedByUserID = clsGlobalUser.CurrentUser.ID;

                if (int_application.Save())
                {

                    {
                        ctrlApplicationShow1._ApplicationID = int_application.ID;
                        ctrlApplicationShow1._LoadData();

                        clsInternationalLicense internationalLicense = new();
                        internationalLicense.ApplicationID = int_application.ID;
                        internationalLicense.DriverID = license.DriverID;
                        internationalLicense.IssuedUsingLocalLicenseID = LocalLicenseID;
                        internationalLicense.IssueDate = DateTime.Now;
                        internationalLicense.ExpirationDate = DateTime.Now.AddYears(10);
                        internationalLicense.IsActive = true;
                        internationalLicense.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
                        if (internationalLicense.Save())
                        {
                            InternationalLicenseID = internationalLicense.ID;
                            MessageBox.Show("International License issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnlicenseinfo.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Failed to issue International License. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create application for International License. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void ctrlLicenseSearch1_OnLicenseSearchFail()
        {
            btnhistory.Enabled = false;
            btnlicenseinfo.Enabled = false;
            btnIntIssue.Enabled = false;
            ctrlLicenseInfo1._LicenseID = -1;
            ctrlLicenseInfo1._LoadData();
            ctrlApplicationShow1._ApplicationID = -1;
            ctrlApplicationShow1._LoadData_Int();
            ctrlApplicationShow1.lblnametxt.Text = "";
            
        }
    }
}
