using DVLD_Business;
using DVLD_General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Presentation
{
    public partial class frmTestSchedule : frmGeneral
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        int localID = -1;
        int applicationID_ForLocal = -1;
        int _ID = -1;
        int trials;
        enTestType testType;

        clsLocal_DLA localDLA;

        clsTestAppointment _TestAppointment;

        DateTime maxAppointmentDate = DateTime.Now; // Initialize with the smallest possible date


        public frmTestSchedule(enTestType testType, int LocalID, int ID,DateTime maxDate )
        {
            InitializeComponent();
            this.testType = testType;
            lblGeneralTitle.Text = frmTestAppointments.GetTestTypeName(this.testType) + " Test Schedule";
            this.localID = LocalID;
            this.localDLA = clsLocal_DLA.GetLocalDLAByID(localID);
            this.applicationID_ForLocal = localDLA.ApplicationID;
            this.maxAppointmentDate = maxDate; // Set the maximum appointment date


            this._ID = ID;

            

        }

        private void frmTestSchedule_Load(object sender, EventArgs e)
        {
            lblidtxt.Text = localID.ToString();
            lbllicensetxt.Text = clsLicenseClass.Find(localDLA.LicenseClassID).ClassName;
            lblnametxt.Text = clsPeople.Find(clsApplication.GetApplicationByID(applicationID_ForLocal).ApplicantPersonID).FirstName
                + " " + clsPeople.Find(clsApplication.GetApplicationByID(applicationID_ForLocal).ApplicantPersonID).LastName;
            lbltrialtxt.Text = clsTestAppointment.GetFailedTestsByTestTypeForLocalDLA(localID, (int)testType).ToString();
            // Format as currency with 2 decimal places (or just number with 2 decimal places)
            lblfeestxt.Text = clsTestType.GetByID((int)testType).Fees.ToString("0.00");

            trials = Convert.ToInt32(lbltrialtxt.Text);
            if (trials == 0)
            {
                lblid2.Enabled = false;
                lblid2txt.Visible = false;
                lblfees2txt.Enabled = false;
                lblfees2txt.Text = clsApplicationType.GetByID(7).Fees.ToString("0.00");
                lbltotaltxt.Text = Convert.ToDecimal(lblfeestxt.Text).ToString("0.00");
            }
            else
            {
                lblid2.Enabled = true;
                lblid2txt.Visible = true;
                lblfees2txt.Enabled = true;
                lblfees2txt.Text = clsApplicationType.GetByID(7).Fees.ToString("0.00");
                decimal total = Convert.ToDecimal(lblfeestxt.Text) + Convert.ToDecimal(lblfees2txt.Text);
                lbltotaltxt.Text = total.ToString("0.00");
            }

            if (_ID == -1)
            {
                _Mode = enMode.AddNew;

                LoadNew();
            }
            else
            {
                _Mode = enMode.Update;

                LoadExisting(_ID);

            }
        }
        private void LoadNew()
        {
            date.MinDate = maxAppointmentDate;
            _TestAppointment = new clsTestAppointment();
            date.Value = maxAppointmentDate;


        }
        private void LoadExisting(int ID)
        {
            _TestAppointment = clsTestAppointment.GetTestAppointmentByID(ID);
            date.MinDate = _TestAppointment.AppointmentDate;
            date.Value = _TestAppointment.AppointmentDate;



        }

        private void btnLocalSave_Click(object sender, EventArgs e)
        {

            _TestAppointment.TestTypeID = (int)testType;
            _TestAppointment.LocalDrivingLicenseApplicationID = localID;
            _TestAppointment.AppointmentDate = date.Value;
            _TestAppointment.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
            _TestAppointment.PaidFees = Convert.ToDecimal(lblfeestxt.Text);
            _TestAppointment.IsLocked = false;
            if (trials == 0)
                _TestAppointment.RetakeTestApplicationID = -1;
            else
            {
                clsApplication RetakeApplication = new clsApplication();
                RetakeApplication.ApplicationDate = DateTime.Now;
                RetakeApplication.ApplicationTypeID = 7;
                RetakeApplication.ApplicationStatus = enApplicationStatus.New;
                RetakeApplication.LastStatusDate = DateTime.Now;
                RetakeApplication.PaidFees = clsApplicationType.GetByID(7).Fees;
                RetakeApplication.CreatedByUserID = clsGlobalUser.CurrentUser.ID;
                RetakeApplication.ApplicantPersonID = clsPeople.Find(clsApplication.GetApplicationByID(applicationID_ForLocal).ApplicantPersonID).ID;
                if (RetakeApplication.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = RetakeApplication.ID;
                }
                else
                {
                    MessageBox.Show("Error in saving retake test application");
                    return;
                }
            }

            if (_TestAppointment.Save())
            {
                MessageBox.Show("Test Appointment Saved Successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in saving test appointment");
            }


        }

        private void btnTestAppAddNew_Click(object sender, EventArgs e)
        {

        }
    }
}
