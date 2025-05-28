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
    public partial class frmApplications : Form
    {
        public frmApplications()
        {
            InitializeComponent();
        }

        private void pbSettingsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApplications_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084); // Fixed size
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);

        }

        private void btnApplicationTypes_Click(object sender, EventArgs e)
        {
            frmApplicationTypes frmApplicationTypes = new frmApplicationTypes();
            frmApplicationTypes.ShowDialog();

        }

        private void btnTestTypes_Click(object sender, EventArgs e)
        {
            frmTestTypes frmTestTypes = new frmTestTypes();
            frmTestTypes.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            frmLocalDLA_Main frmLocalDLA_Main = new frmLocalDLA_Main();
            frmLocalDLA_Main.ShowDialog();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            frmInternationalLicenses frmInternationalLicenses = new frmInternationalLicenses();
            frmInternationalLicenses.ShowDialog();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            frmRenewLicense frmRenewLicense = new frmRenewLicense();
            frmRenewLicense.ShowDialog();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            frmReplaceLicense frmReplaceLicense = new frmReplaceLicense();
            frmReplaceLicense.ShowDialog();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            frmDetainedLicenses frmDetainedLicenses = new frmDetainedLicenses();
            frmDetainedLicenses.ShowDialog();
        }
    }
}
