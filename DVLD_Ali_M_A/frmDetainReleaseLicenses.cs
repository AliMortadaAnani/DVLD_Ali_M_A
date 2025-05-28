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
    public partial class frmDetainReleaseLicenses : frmGeneral
    {
        int LicenseID;
        enLicenseMode Mode;
        public frmDetainReleaseLicenses(int LicenseID, enLicenseMode Mode)
        {
            InitializeComponent();
            this.LicenseID = LicenseID;
            this.Mode = Mode;
            if (Mode == enLicenseMode.Release)
            {

                lblGeneralTitle.Text = "Release License Application";
                btnIntIssue.Text = "Release Local Driving License";
                ctrlLicenseDetain1.Mode = enLicenseMode.Release;
                ctrlDetainReleaseInfo1.Mode = enLicenseMode.Release;
                ctrlDetainReleaseInfo1._LoadReleaseBeforeSearch();
            }
            else
            {
                lblGeneralTitle.Text = "Detain License Application";
                btnIntIssue.Text = "Detain Local Driving License";
                ctrlLicenseDetain1.Mode = enLicenseMode.Detain;
                ctrlDetainReleaseInfo1.Mode = enLicenseMode.Detain;
                ctrlDetainReleaseInfo1._LoadDetainBeforeSearch();
            }

            btnhistory.Enabled = false; // Disable history button for detain/release licenses
            btnIntIssue.Enabled = false; // Disable international issue button for detain/release licenses
            Reset();
            
            ctrlLicenseInfo1._LicenseID = LicenseID;
            ctrlLicenseInfo1._LoadData();

            // load detain data

            switch (Mode)
            {
                case enLicenseMode.Detain:
                    ctrlDetainReleaseInfo1.LicenseID = LicenseID;
                    ctrlDetainReleaseInfo1._LoadDetainAfterSearch();
                    break;
                case enLicenseMode.Release:
                    ctrlDetainReleaseInfo1.LicenseID = LicenseID;
                    ctrlDetainReleaseInfo1._LoadReleaseAfterSearch();
                    break;
            }


            btnIntIssue.Enabled = true;
            btnhistory.Enabled = true;
            ctrlLicenseDetain1.Visible = false;
        }

        public frmDetainReleaseLicenses(enLicenseMode Mode)
        {
            InitializeComponent();
            ctrlLicenseDetain1.Visible = true ;
            this.Mode = Mode;
            if (Mode == enLicenseMode.Release)
            {

                lblGeneralTitle.Text = "Release License Application";
                btnIntIssue.Text = "Release Local Driving License";
                ctrlLicenseDetain1.Mode = enLicenseMode.Release;
                ctrlDetainReleaseInfo1.Mode = enLicenseMode.Release;
                ctrlDetainReleaseInfo1._LoadReleaseBeforeSearch();
            }
            else
            {
                lblGeneralTitle.Text = "Detain License Application";
                btnIntIssue.Text = "Detain Local Driving License";
                ctrlLicenseDetain1.Mode = enLicenseMode.Detain;
                ctrlDetainReleaseInfo1.Mode = enLicenseMode.Detain;
                ctrlDetainReleaseInfo1._LoadDetainBeforeSearch();
            }

            btnhistory.Enabled = false; // Disable history button for detain/release licenses
            btnIntIssue.Enabled = false; // Disable international issue button for detain/release licenses

        }

        private void Reset()
        {
            btnIntIssue.Enabled = false;
            btnhistory.Enabled = false;
            ctrlLicenseInfo1._LicenseID = -1;
            ctrlLicenseInfo1._LoadData();
            switch (Mode)
            {
                case enLicenseMode.Detain:
                    ctrlDetainReleaseInfo1.ResetAllFields();
                    ctrlDetainReleaseInfo1._LoadDetainBeforeSearch();
                    break;
                case enLicenseMode.Release:
                    ctrlDetainReleaseInfo1.ResetAllFields();
                    ctrlDetainReleaseInfo1._LoadReleaseBeforeSearch();
                    break;
            }
        }

        private void ctrlLicenseDetain1_OnLicenseSearchComplete(int obj)
        {   
            Reset();
            LicenseID = obj;
            ctrlLicenseInfo1._LicenseID = LicenseID;
            ctrlLicenseInfo1._LoadData();

            // load detain data

            switch (Mode)
            {
                case enLicenseMode.Detain:
                    ctrlDetainReleaseInfo1.LicenseID = LicenseID;
                    ctrlDetainReleaseInfo1._LoadDetainAfterSearch();
                    ctrlDetainReleaseInfo1.mtbUsersFilterInput.Focus();
                    break;
                case enLicenseMode.Release:
                    ctrlDetainReleaseInfo1.LicenseID = LicenseID;
                    ctrlDetainReleaseInfo1._LoadReleaseAfterSearch();
                    break;
            }


            btnIntIssue.Enabled = true;
            btnhistory.Enabled = true;



        }

        private void ctrlLicenseDetain1_OnLicenseSearchFail()
        {
            Reset();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            int appid = clsLicense.GetLicense(LicenseID).ApplicationID;
            int personid = clsApplication.GetApplicationByID(appid).ApplicantPersonID;
            frmShowLicenseHistory frm = new frmShowLicenseHistory(personid);
            frm.ShowDialog();
            ctrlLicenseInfo1._LoadData();
           
        }

        private void btnIntIssue_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case enLicenseMode.Detain:
                    
                    clsDetainedLicense detainedLicense = new();
                    detainedLicense.LicenseID = LicenseID;
                    detainedLicense.DetainDate = DateTime.Now;
                    detainedLicense.FineFees = Convert.ToDecimal(ctrlDetainReleaseInfo1.mtbUsersFilterInput.Text);

                    detainedLicense.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
                    detainedLicense.IsReleased = false;

                    if (detainedLicense.Save())
                    {
                        MessageBox.Show($"License with id {LicenseID} detained successfully.");
                        ctrlDetainReleaseInfo1._LoadAfterReleaseDetain();
                        ctrlLicenseInfo1._LoadData();
                        btnIntIssue.Enabled = false; // Disable the button after successful detain
                    }
                    else
                    {
                        MessageBox.Show("Failed to detain the license. Please try again.");
                    }
                    break;
                case enLicenseMode.Release:
                    decimal appFee = clsApplicationType.GetByID((int)enApplicationType.ReleaseDetained).Fees;
                    string input = ctrlDetainReleaseInfo1.mtbUsersFilterInput.Text.Trim();

                    decimal finefees = Convert.ToDecimal(input);

                    int totalFee = (int)(finefees) + (int)appFee;
                    DialogResult result = MessageBox.Show(
                        $"This license requires a fine fee of {finefees} USD and a fee of {appFee} USD for the release application.\n" +
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


                    int License_appid = clsLicense.GetLicense(LicenseID).ApplicationID;
                    int personid = clsApplication.GetApplicationByID(License_appid).ApplicantPersonID;
                    clsApplication application = new();
                    application.ApplicantPersonID = personid;
                    application.ApplicationDate = DateTime.Now;
                    application.ApplicationStatus = enApplicationStatus.Completed;
                    application.ApplicationTypeID = (int)enApplicationType.ReleaseDetained;
                    application.LastStatusDate = DateTime.Now;
                    application.PaidFees = clsApplicationType.GetByID((int)enApplicationType.ReleaseDetained).Fees;
                    application.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
                    if (application.Save())
                    {
                        clsDetainedLicense detain = clsDetainedLicense.GetDetainedLicenseByLicenseID(LicenseID);
                        if (detain != null)
                        {
                            detain.IsReleased = true;
                            detain.ReleaseDate = DateTime.Now;
                            detain.ReleasedByUserID = clsGlobalUser.CurrentUser.ID;
                            detain.ReleaseApplicationID = application.ID;
                            if (detain.Save())
                            {
                                MessageBox.Show($"License with id {LicenseID} released successfully.");
                                ctrlDetainReleaseInfo1._LoadAfterReleaseDetain();
                                ctrlLicenseInfo1._LoadData();
                                btnIntIssue.Enabled = false; // Disable the button after successful release
                            }
                            else
                            {
                                MessageBox.Show("Failed to release the license. Please try again.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No detain record found for this license.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to create release application. Please try again.");
                    }
                    break;
            }
        }
    }
}
