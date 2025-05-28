using DVLD_Business;
using DVLD_General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmRenewLicense : frmGeneral
    {
        int OldLicenseID = -1;
        int NewLicenseID = -1;
        int PersonID = -1;

        public frmRenewLicense()
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Renew Local Driving License";
            btnhistory.Enabled = false;
            btnlicenseinfo.Enabled = false;
            btnIntIssue.Enabled = false;
            ctrlApplicationShow1._LoadData_Renew();
            tbnotes.Enabled = true;
        }



        private void ctrlLicenseRenew1_OnLicenseSearchComplete(int obj)
        {
            OldLicenseID = obj;
            ctrlLicenseInfo1._LicenseID = OldLicenseID;
            ctrlLicenseInfo1._LoadData();
            ctrlApplicationShow1._LoadData_Renew();
            PersonID = clsApplication.GetApplicationByID(clsLicense.GetLicense(obj).ApplicationID).ApplicantPersonID;
            ctrlApplicationShow1.lblnametxt.Text = clsPeople.Find(PersonID).FirstName + " " + clsPeople.Find(PersonID).LastName;
            lblLicensefeestxt.Text = clsLicenseClass.Find(clsLicense.GetLicense(obj).LicenseClass).ClassFees.ToString();


            btnIntIssue.Enabled = true;
            btnhistory.Enabled = true;

            if (clsLicense.GetLicense(obj).ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("Local Driving License for this driver is not expired.\n" +
                    "You cannot renew it");
                btnIntIssue.Enabled = false;
                btnlicenseinfo.Enabled = false;



                return;
            }
        }

        private void ctrlLicenseRenew1_OnLicenseSearchFail()
        {
            Reset();
        }
        private void Reset()
        {
            btnhistory.Enabled = false;
            btnlicenseinfo.Enabled = false;
            btnIntIssue.Enabled = false;
            ctrlLicenseInfo1._LicenseID = -1;
            ctrlLicenseInfo1._LoadData();
            ctrlApplicationShow1._ApplicationID = -1;
            ctrlApplicationShow1._LoadData_Renew();
            ctrlApplicationShow1.lblnametxt.Text = "";
            lblLicensefeestxt.Text = "";
            Renewlicenseidtxt.Text = "";
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            int appid = clsLicense.GetLicense(OldLicenseID).ApplicationID;
            int personid = clsApplication.GetApplicationByID(appid).ApplicantPersonID;
            frmShowLicenseHistory frm = new frmShowLicenseHistory(personid);
            frm.ShowDialog();
            ctrlLicenseInfo1._LoadData();
            ctrlApplicationShow1.lblnametxt.Text = clsPeople.Find(PersonID).FirstName + " " + clsPeople.Find(PersonID).LastName;
        }

        private void btnlicenseinfo_Click(object sender, EventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(NewLicenseID);
            frmShowLicense.ShowDialog();
        }

        private void btnIntIssue_Click(object sender, EventArgs e)
        {
            var old_license = clsLicense.GetLicense(OldLicenseID);
            var old_application = clsApplication.GetApplicationByID(old_license.ApplicationID);
            if (!old_license.IsActive)
            {
                MessageBox.Show(
                    "The local license is not active.\n\n" +
                    "You must reactivate it before renewing it's expiration date.",
                    "License Inactive",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    0,
                    false
                );
                Reset();
                return;
            }
            else if (clsLicense.IsLicenseDetained(OldLicenseID))
            {
                MessageBox.Show(
                    "The local license is detained.\n\n" +
                    "Renewing license is not allowed while it is in this status.",
                    "License Detained",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    0,
                    false
                );
                Reset();
                return;
            }
            else
            {   // Get the required fee amount (replace 500 with your actual fee or get it from database)
                int licenseFee = Convert.ToInt32(clsLicenseClass.Find(clsLicense.GetLicense(OldLicenseID).LicenseClass).ClassFees); // Or: clsLicense.GetLicenseFee(_LicenseID);
                int appfee = Convert.ToInt32(clsApplicationType.GetByID((int)enApplicationType.Renew).Fees);
                int totalFee = licenseFee + appfee; 
                DialogResult result = MessageBox.Show(
                    $"This license requires a fee of {licenseFee} USD and a fee of {appfee} USD for the application.\n" +
                    $"Total fees = {totalFee} USD.\n" +
                    $"Do you want to proceed with payment?",
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
                clsApplication new_application = new();
                new_application.ApplicantPersonID = old_application.ApplicantPersonID;
                new_application.ApplicationTypeID = (int)enApplicationType.Renew;
                new_application.ApplicationStatus = enApplicationStatus.Completed;
                new_application.ApplicationDate = DateTime.Now;
                new_application.LastStatusDate = DateTime.Now;
                new_application.PaidFees = clsApplicationType.GetByID((int)enApplicationType.Renew).Fees;
                new_application.CreatedByUserID = clsGlobalUser.CurrentUser.ID;

                if (new_application.Save())
                {

                    {
                        ctrlApplicationShow1._ApplicationID = new_application.ID;
                        ctrlApplicationShow1._LoadData();

                        clsLicense new_license = new();
                        new_license.ApplicationID = new_application.ID;
                        new_license.DriverID = old_license.DriverID;
                        
                        new_license.IssueDate = DateTime.Now;
                        new_license.ExpirationDate = DateTime.Now.AddYears(10);
                        new_license.IsActive = true;
                        new_license.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
                        new_license.LicenseClass = old_license.LicenseClass;
                        new_license.IssueReason = (int)enIssueReason.Renew;
                        new_license.Notes = tbnotes.Text;
                        new_license.PaidFees = clsLicenseClass.Find(old_license.LicenseClass).ClassFees;
                        if (new_license.Save())
                        {
                            NewLicenseID = new_license.ID;
                            Renewlicenseidtxt.Text = NewLicenseID.ToString();
                            MessageBox.Show("License renewed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnlicenseinfo.Enabled = true;
                            btnIntIssue.Enabled = false;
                            clsLicense.DeactivateLicense(OldLicenseID);
                            ctrlLicenseInfo1._LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to renew License. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create application for Renewing License. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
