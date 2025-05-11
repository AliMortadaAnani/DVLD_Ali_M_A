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
    public partial class frmIssueLicense : frmGeneral
    {
        int localID = -1;
        int applicationID = -1;
        clsLocal_DLA localDLA;
        clsApplication localDLA_Application;
        public frmIssueLicense(int ApplicationID, int LocalID)
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Issue Driver License";
            ctrlApplicationShow1._ApplicationID = ApplicationID;
            ctrlLocal_dlA_Details1._LocalDLA_ID = LocalID;
            this.localID = LocalID;
            this.applicationID = ApplicationID;
            this.localDLA = clsLocal_DLA.GetLocalDLAByID(localID);
            this.localDLA_Application = clsApplication.GetApplicationByID(localDLA.ApplicationID);
        }

        private void btnPeopleSave_Click(object sender, EventArgs e)
        {
            clsDriver driver;
            if (clsDriver.IsDriverExistByPersonID(localDLA_Application.ApplicantPersonID))
            {
                driver = clsDriver.Find(localDLA_Application.ApplicantPersonID);
            }
            else

           {    
                
            driver = new clsDriver();
            driver.CreatedDate = DateTime.Now;
            driver.CreateByUserID = clsGlobalUser.CurrentUser.ID;
            driver.PersonID = localDLA_Application.ApplicantPersonID;

            }
            if (driver.Save())
            {
               clsLicense license = new clsLicense();
                license.DriverID = driver.ID;
                license.ApplicationID = applicationID;
                license.LicenseClass = localDLA.LicenseClassID;
                license.IssueDate = DateTime.Now;
                license.ExpirationDate = DateTime.Now.AddYears(10);
                license.PaidFees = clsLicenseClass.Find(localDLA.LicenseClassID).ClassFees;
                license.IsActive = true;
                license.IssueReason = (byte)enIssueReason.FirstTime;
                license.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
                license.Notes =  tbnotes.Text;
                if (license.Save())
                {
                    clsApplication.UpdateApplication_Status_LastStatusDate(applicationID, enApplicationStatus.Completed, DateTime.Now);

                    string successMessage = $"The driver's license has been successfully processed.\n\n" +
                       $"Person {driver.PersonID} is now registered as a driver (ID: {driver.ID}) " +
                       $"with local driving license {license.ID}.";

                    MessageBox.Show(successMessage, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to issue Driver License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Failed to issue Driver License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
