using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using Microsoft.VisualBasic.ApplicationServices;

namespace DVLD_Presentation
{
    public partial class ctrlLocalDLA_AddUpdate : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int _ID ;
        clsLocal_DLA _LocalDLA;
        clsApplication _Application;

        DateTime DateNow;
        DateTime LastStatusDate;
       

        public ctrlLocalDLA_AddUpdate()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.Load += ctrlLocalDLA_AddUpdate_Load;
            }
           

        }

        private void ctrlLocalDLA_AddUpdate_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                _FillLicenseClassesInComoboBox();
                if (_ID == -1)
                {
                    _Mode = enMode.AddNew;
                    LoadNewLocal();
                }
                else
                {
                    _Mode = enMode.Update;
                    LoadExistingLocal(_ID);

                }
            }
        }
        private void _FillLicenseClassesInComoboBox()
        {
            cbLicenses.Items.Clear(); // Clear existing items first
            DataTable dtlicenses = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow row in dtlicenses.Rows)
            {

                cbLicenses.Items.Add(row["ClassName"]);

            }

        }
        private void LoadNewLocal()
        {
            // Get current date and time
            DateNow = DateTime.Now;
            // Format as DD/MM/YYYY and store in a string
            string ApplicationDateFormat = DateNow.ToString("dd/MM/yyyy");

            int ApplicationFees = (int)clsApplicationType.GetByID(1).Fees;



            lblid.Enabled = false;
            lblidtxt.Visible = false;
            _LocalDLA = new clsLocal_DLA();
            _Application = new clsApplication();

            lbldatetxt.Text = ApplicationDateFormat;
            cbLicenses.SelectedIndex = 0;
            lblfeestxt.Text = ApplicationFees.ToString();
            lblusertxt.Text = clsGlobalUser.CurrentUser.UserName;


            LastStatusDate = DateNow;

        }
        private void LoadExistingLocal(int ID)
        {
            _LocalDLA = clsLocal_DLA.GetLocalDLAByID(ID);
            _Application = clsApplication.GetApplicationByID(_LocalDLA.ApplicationID);
            if (_LocalDLA == null)
            {
                MessageBox.Show("No Local DLA with ID = " + ID);
                ParentForm?.Close(); // Safe null-check

                return;
            }

            lblid.Enabled = true;
            lblidtxt.Visible = true;
            lblidtxt.Text = _LocalDLA.ID.ToString();


            DateNow = _Application.ApplicationDate;

            string ExistingDateFormat = DateNow.ToString("dd/MM/yyyy");

            lbldatetxt.Text = ExistingDateFormat;

            int ExistingFees = (int)_Application.PaidFees;

            lblfeestxt.Text = ExistingFees.ToString();

            lblusertxt.Text = clsUser.Find(_Application.CreatedByUserID).UserName;

            string ExistingLicenseClass = clsLicenseClass.Find(_LocalDLA.LicenseClassID).ClassName;

            cbLicenses.SelectedIndex = cbLicenses.FindString(ExistingLicenseClass);

            LastStatusDate = _Application.LastStatusDate;




        }
      
        private void btnLocalSave_Click(object sender, EventArgs e)
        {
            int LicenseClassId = clsLicenseClass.Find(cbLicenses.Text).ID;
            int CreatedByUserId = clsUser.Find(lblusertxt.Text).ID;
            string NationalNumber = clsPeople.Find(ctrlPeopleShowDetails._PersonID).NationalNb;


            if (clsLocal_DLA.IsLicenseClassExist_ForPerson(NationalNumber, cbLicenses.Text)||
                clsLicense.CheckPersonHasLicenseClass(ctrlPeopleShowDetails._PersonID,LicenseClassId))
            {
                MessageBox.Show($"Warning: Local DLA for license '{cbLicenses.Text}' already exists.",
                              "Duplicate License",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            _Application.ApplicationDate = DateNow;
            _Application.ApplicationTypeID = 1;
            _Application.ApplicationStatus = DVLD_General.enApplicationStatus.New;
            _Application.LastStatusDate = LastStatusDate;
            _Application.PaidFees = Convert.ToDecimal(lblfeestxt.Text);
            _Application.CreatedByUserID = CreatedByUserId;
            _Application.ApplicantPersonID = ctrlPeopleShowDetails._PersonID;

            if(_Application.Save() == false)
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
                return;
            }

            _LocalDLA.ApplicationID = _Application.ID;
            _LocalDLA.LicenseClassID = LicenseClassId;

            

            

             if (_LocalDLA.Save())
            {
                MessageBox.Show("Local Driving License Application Saved Successfully.");
                frmLocal_DLA_AddUpdate.lbLocalTitle.Text = "Edit Local DLA Details";
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
                return;
            }

            _Mode = enMode.Update;
            _Application.Mode = clsApplication.enMode.Update;

            lblid.Enabled = true;
            lblidtxt.Visible = true;
            lblidtxt.Text = _LocalDLA.ID.ToString();
        }
    }
}
