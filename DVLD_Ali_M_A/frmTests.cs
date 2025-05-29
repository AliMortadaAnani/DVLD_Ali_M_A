using DVLD_Business;
using DVLD_General;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmTests : frmGeneral
    {
        public int TestAppointmentID { get; set; }
        clsTestAppointment testAppointment;
        int localid;
        clsLocal_DLA local_DLA;
        clsApplication local_DLA_Application;
        int trials;
        public frmTests(int _TestAppointmentID)
        {
            InitializeComponent();

            this.TestAppointmentID = _TestAppointmentID;
            testAppointment = clsTestAppointment.GetTestAppointmentByID(TestAppointmentID);
            lblGeneralTitle.Text = frmTestAppointments.GetTestTypeName((enTestType)testAppointment.TestTypeID) + " Test";
            this.localid = testAppointment.LocalDrivingLicenseApplicationID;
            this.local_DLA = clsLocal_DLA.GetLocalDLAByID(localid);
            this.local_DLA_Application = clsApplication.GetApplicationByID(local_DLA.ApplicationID);
        }

        private void frmTests_Load(object sender, EventArgs e)
        {
            lblidtxt.Text = localid.ToString();
            lbllicensetxt.Text = clsLicenseClass.Find(local_DLA.LicenseClassID).ClassName;
            lblnametxt.Text = clsPeople.Find(clsApplication.GetApplicationByID(local_DLA_Application.ID).ApplicantPersonID).FirstName
                + " " + clsPeople.Find(clsApplication.GetApplicationByID(local_DLA_Application.ID).ApplicantPersonID).LastName;
            lbltrialtxt.Text = clsTestAppointment.GetFailedTestsByTestTypeForLocalDLA(localid, (int)testAppointment.TestTypeID).ToString();
            lblfeestxt.Text = clsTestType.GetByID((int)testAppointment.TestTypeID).Fees.ToString();
            date.Value = testAppointment.AppointmentDate;
            trials = Convert.ToInt32(lbltrialtxt.Text);
        }

        private void btnPeopleSave_Click(object sender, EventArgs e)
        {
            if (rbfail.Checked == false && rbpass.Checked == false)
            {
                MessageBox.Show("Please select a result for the test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsTest test = new clsTest();
            test.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
            test.Notes = tbnotes.Text;
            test.TestAppointmentID = TestAppointmentID;
            test.TestResult = rbfail.Checked ? false : true;
            if (test.Save())
            {
                // Update the test appointment status
                clsTestAppointment.LockTestAppointment(TestAppointmentID);
                if (trials > 0)
                { clsApplication.UpdateApplication_Status_LastStatusDate(testAppointment.RetakeTestApplicationID, enApplicationStatus.Completed, DateTime.Now); }
                MessageBox.Show("Test result saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in saving test result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            string documentation = "This form allows you to mark a test as passed or failed using two radio buttons.\nYou can optionally add notes about the test.\nThe form displays test appointment details and the number of trials (times this test was taken by the same person for this license class).\nIf the test is passed on the first attempt, the trial count will be 1.\nEach failed attempt increments the trial count.";
            frmDocumentation frmDocumentation = new frmDocumentation(documentation);
            frmDocumentation.ShowDialog();

        }
    }
}
