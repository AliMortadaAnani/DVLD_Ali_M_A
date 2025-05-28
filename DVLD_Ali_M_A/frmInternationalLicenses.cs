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
    public partial class frmInternationalLicenses : frmGeneral
    {
        public frmInternationalLicenses()
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Manage International\nLicenses Applications";
        }

        private void frmInternationalLicenses_Load(object sender, EventArgs e)
        {
            dgvLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _RefreshLocalList();
            _RefreshFilterInput();
        }

        private void _RefreshLocalList()
        {
            dgvLocal.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
            lblLocalTotalRecordsNb.Text = dgvLocal.RowCount.ToString();
        }
        private void _RefreshFilterInput()
        {
            if (cbUsersFilterBox.SelectedIndex == cbUsersFilterBox.FindString("None"))
            {
                mtbUsersFilterInput.Visible = false;
                cbUsersStatusOptions.Visible = false;
            }
        }
        private void btnLocalAddNew_Click(object sender, EventArgs e)
        {
            frmInternationalLicensesAdd frm = new();
            frm.ShowDialog();
            _RefreshLocalList();
        }

        private void showLicenseStripMenuItem_Click(object sender, EventArgs e)
        {

            int licenseid = (int)dgvLocal.CurrentRow.Cells[0].Value;
            frmInternationalLicenseShowDetails frm = new(licenseid);
            frm.ShowDialog();
            _RefreshLocalList();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int applicationid = (int)dgvLocal.CurrentRow.Cells[1].Value;

            int personid = clsApplication.GetApplicationByID(applicationid).ApplicantPersonID;


            frmShowLicenseHistory frm = new(personid);
            frm.ShowDialog();
            _RefreshLocalList();
        }



        private void cbUsersFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUsersStatusOptions.Visible = false;
            cbUsersStatusOptions.SelectedIndex = cbUsersStatusOptions.FindString("All");
            mtbUsersFilterInput.Visible = true;
            _RefreshLocalList();
            switch (cbUsersFilterBox.SelectedItem?.ToString())
            {
                case "None":
                    mtbUsersFilterInput.Visible = false;
                    _RefreshLocalList();
                    break;

                case "InternationalLicenseID":
                case "LocalLicenseID":
                case "DriverID":
                    mtbUsersFilterInput.Text = string.Empty;
                    mtbUsersFilterInput.Mask = "000000";
                    mtbUsersFilterInput.Focus();
                    break;

                case "IsActive":
                    mtbUsersFilterInput.Visible = false;
                    cbUsersStatusOptions.Visible = true;
                    dgvLocal.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
                    break;

                default:
                    mtbUsersFilterInput.Text = string.Empty;
                    mtbUsersFilterInput.Mask = null;
                    mtbUsersFilterInput.Focus();
                    break;
            }
        }

        private void mtbUsersFilterInput_TextChanged(object sender, EventArgs e)
        {
            string input = mtbUsersFilterInput.Text.Trim();

            string selectedFilter = cbUsersFilterBox.Text;

            switch (selectedFilter)
            {
                case "InternationalLicenseID":
                    if (int.TryParse(input, out int id))
                    {
                        dgvLocal.DataSource = clsInternationalLicense.GetInternationalLicenseByID(id);
                    }
                    break;


                case "LocalLicenseID":
                    if (int.TryParse(input, out int localid))
                    {
                        dgvLocal.DataSource = clsInternationalLicense.GetInternationalLicenseByID(localid);
                    }
                    break;

                case "DriverID":
                    if (int.TryParse(input, out int driverid))
                    {
                        dgvLocal.DataSource = clsInternationalLicense.GetInternationalLicensesByDriverID(driverid);
                    }
                    break;




            }


            dgvLocal.Text = dgvLocal.RowCount.ToString();
        }

        private void cbUsersStatusOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbUsersStatusOptions.SelectedItem?.ToString())
            {
                case "All":
                    dgvLocal.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
                    break;


                case "Active":
                    dgvLocal.DataSource = clsInternationalLicense.GetInternationalLicensesBIsActive(true);
                    break;

                case "Not Active":
                    dgvLocal.DataSource = clsInternationalLicense.GetInternationalLicensesBIsActive(false);
                    break;
            }
            dgvLocal.Text = dgvLocal.RowCount.ToString();
        }
    }
}
