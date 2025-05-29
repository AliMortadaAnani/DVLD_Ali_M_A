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
    public partial class frmReplaceLicense : frmGeneral
    {
        public frmReplaceLicense()
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Replace Local License";
            btnhistory.Enabled = false;
            btnlicenseinfo.Enabled = false;
            btnIntIssue.Enabled = false;
            rblost.Checked = true; // Default to Replacement Lost
            rbdmg.Checked = false; // Ensure Replacement Damaged is unchecked
            LoadApp();

        }

        private void LoadApp()
        {
            enApplicationType type = enApplicationType.ReplacementLost;
            if (rblost.Checked)
                type = enApplicationType.ReplacementLost;
            else if (rbdmg.Checked)
                type = enApplicationType.ReplacementDamaged;

            switch (type)
            {
                case enApplicationType.ReplacementDamaged:
                    ctrlApplicationShow1._LoadData_Replace_Damaged();
                    break;
                case enApplicationType.ReplacementLost:
                    ctrlApplicationShow1._LoadData_Replace_Lost();
                    break;
            }
        }

        int OldLicenseID = -1;
        int NewLicenseID = -1;
        int PersonID = -1;




        private void Reset()
        {
            btnhistory.Enabled = false;
            btnlicenseinfo.Enabled = false;
            btnIntIssue.Enabled = false;
            ctrlLicenseInfo1._LicenseID = -1;
            ctrlLicenseInfo1._LoadData();
            ctrlApplicationShow1._ApplicationID = -1;
            rblost.Checked = true; // Default to Replacement Lost
            rbdmg.Checked = false; // Ensure Replacement Damaged is unchecked
            LoadApp();
            ctrlApplicationShow1.lblnametxt.Text = "";
            lblLicensefeestxt.Text = "";
            Renewlicenseidtxt.Text = "";
        }
        private void ctrlLicenseRenew1_OnLicenseSearchComplete_1(int obj)
        {
            Renewlicenseidtxt.Text = "";
            OldLicenseID = obj;
            ctrlLicenseInfo1._LicenseID = OldLicenseID;
            ctrlLicenseInfo1._LoadData();
            LoadApp();
            PersonID = clsApplication.GetApplicationByID(clsLicense.GetLicense(obj).ApplicationID).ApplicantPersonID;
            ctrlApplicationShow1.lblnametxt.Text = clsPeople.Find(PersonID).FirstName + " " + clsPeople.Find(PersonID).LastName;
            lblLicensefeestxt.Text = clsLicenseClass.Find(clsLicense.GetLicense(obj).LicenseClass).ClassFees.ToString();


            btnIntIssue.Enabled = true;
            btnhistory.Enabled = true;
            rblost.Enabled = true;
            rbdmg.Enabled = true;

            if (!clsLicense.GetLicense(obj).IsActive)
            {
                MessageBox.Show("Local Driving License for this driver is not active.\n" +
                    "You cannot replace it");
                btnIntIssue.Enabled = false;
                btnlicenseinfo.Enabled = false;



                return;
            }
        }

        private void ctrlLicenseRenew1_OnLicenseSearchFail_1()
        {
            Reset();
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
            enApplicationType type = enApplicationType.ReplacementLost;
            if (rblost.Checked)
                type = enApplicationType.ReplacementLost;
            else if (rbdmg.Checked)
                type = enApplicationType.ReplacementDamaged;

            var old_license = clsLicense.GetLicense(OldLicenseID);
            var old_application = clsApplication.GetApplicationByID(old_license.ApplicationID);
            if (!old_license.IsActive)
            {
                MessageBox.Show(
                    "The local license is not active.\n\n" +
                    "You must reactivate it before replacing it.",
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
                    "Replacing license is not allowed while it is in this status.",
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
            {
                int licenseFee = Convert.ToInt32(clsLicenseClass.Find(clsLicense.GetLicense(OldLicenseID).LicenseClass).ClassFees); // Or: clsLicense.GetLicenseFee(_LicenseID);
                int appfee = Convert.ToInt32(clsApplicationType.GetByID((int)type).Fees);
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
                new_application.ApplicationTypeID = (int)type;
                new_application.ApplicationStatus = enApplicationStatus.Completed;
                new_application.ApplicationDate = DateTime.Now;
                new_application.LastStatusDate = DateTime.Now;
                new_application.PaidFees = clsApplicationType.GetByID((int)type).Fees;
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
                        if (type == enApplicationType.ReplacementLost)
                            new_license.IssueReason = (int)enIssueReason.Replacement_for_Lost;
                        else if (type == enApplicationType.ReplacementDamaged)
                            new_license.IssueReason = (int)enIssueReason.Replacement_for_Damaged;


                        new_license.PaidFees = clsLicenseClass.Find(old_license.LicenseClass).ClassFees;
                        if (new_license.Save())
                        {
                            NewLicenseID = new_license.ID;
                            Renewlicenseidtxt.Text = NewLicenseID.ToString();
                            MessageBox.Show("License replaced successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnlicenseinfo.Enabled = true;
                            btnIntIssue.Enabled = false;
                            clsLicense.DeactivateLicense(OldLicenseID);
                            ctrlLicenseInfo1._LoadData();
                            rblost.Enabled = false;
                            rbdmg.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to replace License. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create application for Replacing License. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void rblost_CheckedChanged(object sender, EventArgs e)
        {
            LoadApp();
        }

        private void rbdmg_CheckedChanged(object sender, EventArgs e)
        {
            LoadApp();
        }

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            string documentation = "This form allows you to replace a local driving license due to damage or loss.\nYou must search for a license that is active; otherwise, you cannot proceed.\nThe form displays the selected license details and the related replacement application information.\nWhen you replace the license, the old damaged or lost license will be marked inactive, and the new one will become the active license.\nUse the 'Replace' button to complete the replacement process.\nButtons are also available to view the new replaced license and the license history.";
            frmDocumentation frmDocumentation = new frmDocumentation(documentation);
            frmDocumentation.ShowDialog();

        }
    }

}


