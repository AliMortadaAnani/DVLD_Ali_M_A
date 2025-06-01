using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_General;
using DVLD_Business;

namespace DVLD_Presentation
{
    public partial class ctrlDetainReleaseInfo : UserControl
    {
        public enLicenseMode Mode { get; set; }
        public int LicenseID { get; set; }
        public int DetainID { get; set; }
        public ctrlDetainReleaseInfo()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.Load += ctrlDetainReleaseInfo_Load;
            }
        }

        private void ctrlDetainReleaseInfo_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (Mode == enLicenseMode.Release)
                    _LoadReleaseBeforeSearch();
                else if (Mode == enLicenseMode.Detain)
                    _LoadDetainBeforeSearch();
            }
        }
        public void ResetAllFields()
        {
            // Reset all fields to default values
            detaindatetxt.Text = string.Empty;
            createdusertxt.Text = string.Empty;
            mtbUsersFilterInput.Text = string.Empty;
            mtbUsersFilterInput.Mask = "000";
            errorProvider1.Clear();
            detainIdtxt.Text = string.Empty;
            licenseidtxt.Text = string.Empty;
            releasedusertxt.Text = string.Empty;
            releasedatetxt.Text = string.Empty;
            releasedtxt.Text = string.Empty;
            appidtxt.Text = string.Empty;

        }
        public void _LoadDetainBeforeSearch()
        {
            detaindatetxt.Text = DateTime.Now.ToString("dd/MM/yyyy");
            mtbUsersFilterInput.Enabled = true;
            mtbUsersFilterInput.Text = string.Empty;
            mtbUsersFilterInput.Mask = "000";
            createdusertxt.Text = clsGlobalUser.CurrentUser.UserName;



        }
        public void _LoadReleaseBeforeSearch()
        {   
            
            mtbUsersFilterInput.Enabled = false;
        }
        public void _LoadDetainAfterSearch()
        {
            if(LicenseID <= 0)
            {
                
                return;
            }
            licenseidtxt.Text = LicenseID.ToString();


        }
        public void _LoadReleaseAfterSearch()
        {
            if (LicenseID <= 0)
            {

                return;
            }
            
            clsDetainedLicense detain = clsDetainedLicense.GetDetainedLicenseByLicenseID(LicenseID);
            if (detain == null)
            {
                MessageBox.Show("No detain record found for this license.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            detainIdtxt.Text = detain.ID.ToString();
            licenseidtxt.Text = detain.LicenseID.ToString();
            detaindatetxt.Text = detain.DetainDate.ToString("dd/MM/yyyy");
            mtbUsersFilterInput.Text = Convert.ToInt32(detain.FineFees).ToString();
            createdusertxt.Text = detain.CreatedByUserID.ToString();
            releasedtxt.Text = detain.IsReleased ? "Yes" : "No";


        }
        
        public void _LoadAfterReleaseDetain()
        {
            if (LicenseID <= 0)
            {

                return;
            }
            if (DetainID <= 0)
            {

                return;
            }
            clsDetainedLicense detain = clsDetainedLicense.GetDetainedLicenseByLicenseID(LicenseID);
            if (detain == null)
            {
                MessageBox.Show("No detain record found for this license.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            detainIdtxt.Text = detain.ID.ToString();
            licenseidtxt.Text = detain.LicenseID.ToString();
            detaindatetxt.Text = detain.DetainDate.ToString("dd/MM/yyyy");
            mtbUsersFilterInput.Text = detain.FineFees.ToString("0.00");
            createdusertxt.Text = detain.CreatedByUserID.ToString();
            releasedtxt.Text = detain.IsReleased ? "Yes" : "No";
            releasedatetxt.Text = detain.ReleaseDate == DateTime.MinValue
            ? ""
            : detain.ReleaseDate.ToString("dd/MM/yyyy");

            releasedusertxt.Text = detain.ReleasedByUserID == -1
                ? ""
                : detain.ReleasedByUserID.ToString();

            appidtxt.Text = detain.ReleaseApplicationID == -1
                ? ""
                : detain.ReleaseApplicationID.ToString();


        }

        private void mtbUsersFilterInput_Validating(object sender, CancelEventArgs e)
        {
            string fees = mtbUsersFilterInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(fees))
            {
                e.Cancel = true;
                mtbUsersFilterInput.Focus();
                errorProvider1.SetError(mtbUsersFilterInput, "Cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtbUsersFilterInput, "");
            }
        }
    }
}
