using DVLD_Business;
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
    public partial class frmShowLicenseHistory : frmGeneral
    {
        public int PersonID { get; set; }
        public frmShowLicenseHistory(int PersonID)
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Driver License History";
            this.PersonID = PersonID;
            ctrlPeopleShowDetails._PersonID = PersonID;
            rblocal.Checked = true;

        }

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {

        }

        private void rblocal_CheckedChanged(object sender, EventArgs e)
        {
            if (rblocal.Checked)
            {
                dgvlicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvlicense.DataSource = clsLicense.GetAllLicensesByPersonID(PersonID);
            }
            else
            {
                dgvlicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvlicense.DataSource = clsLicense.GetAllInternationalLicensesByPersonID(PersonID);
            }
        }

        private void rbint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void showLicenseStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rblocal.Checked)
            {
                frmShowLicense frmShowLicense = new frmShowLicense((int)dgvlicense.CurrentRow.Cells[0].Value);
                frmShowLicense.ShowDialog();
            }
            else
            {
                frmInternationalLicenseShowDetails frmInternationalLicenseShowDetails = new frmInternationalLicenseShowDetails((int)dgvlicense.CurrentRow.Cells[0].Value);
                frmInternationalLicenseShowDetails.ShowDialog();
            }
        }
    }
}
