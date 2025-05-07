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
using DVLD_General;

namespace DVLD_Presentation
{
    public partial class ctrlApplicationShow : UserControl
    {
        clsApplication _Application;
        public int _ApplicationID { get; set; }
        public ctrlApplicationShow()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.Load += ctrlApplicationShow_Load;
            }
        }

        private void ctrlApplicationShow_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                _LoadData();
        }

        public string GetStatus(enApplicationStatus status)
        {
            switch (status)
            {
                case enApplicationStatus.New:
                    return "New";
                case enApplicationStatus.Cancelled:
                    return "Cancelled";
                case enApplicationStatus.Completed:
                    return "Completed";

                default:
                    return "Unknown";
            }
        }

        public void _LoadData()
        {
            if (_ApplicationID <= 0)
            {

                return;
            }
            _Application = clsApplication.GetApplicationByID(_ApplicationID);
            if (_Application == null)
            {
                if (!this.DesignMode)
                {
                    MessageBox.Show("Application with ID: " + _ApplicationID + " not found.");
                }
                return;
            }
            lblidtxt.Text = _Application.ID.ToString();
            lblstatustxt.Text = GetStatus(_Application.ApplicationStatus);
            lblfeestxt.Text = _Application.PaidFees.ToString();
            lblnametxt.Text = clsPeople.Find(_Application.ApplicantPersonID).FirstName
                + " " + clsPeople.Find(_Application.ApplicantPersonID).LastName;
            lbltypetxt.Text = clsApplicationType.GetByID(_Application.ApplicationTypeID).Title.ToString();
            lbldatetxt.Text = _Application.ApplicationDate.ToString("dd/MM/yyyy");
            lblstatusdatetxt.Text = _Application.LastStatusDate.ToString("dd/MM/yyyy");
            lblusrtxt.Text = clsUser.Find(_Application.CreatedByUserID).UserName;

        }

        private void btnLicenseShow_Click(object sender, EventArgs e)
        {
            frmPeopleShowDetails frm = new frmPeopleShowDetails(_Application.ApplicantPersonID);
            frm.ShowDialog();

        }
    }
}
