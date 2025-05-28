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
    public partial class frmDetainedLicenses : frmGeneral
    {
        public frmDetainedLicenses()
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Manage Detained Licenses";
            dgvLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _RefreshLocalList();
            _RefreshFilterInput();
        }

        private void cbUsersStatusOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbUsersStatusOptions.SelectedItem?.ToString())
            {
                case "All":
                    dgvLocal.DataSource = clsDetainedLicense.GetAllDetainedLicenses();
                    break;


                case "Released":
                    dgvLocal.DataSource = clsDetainedLicense.GetAllDetainedLicensesByIsReleased(true);
                    break;

                case "Detained":
                    dgvLocal.DataSource = clsDetainedLicense.GetAllDetainedLicensesByIsReleased(false);
                    break;
            }
            dgvLocal.Text = dgvLocal.RowCount.ToString();
        }



        private void _RefreshLocalList()
        {
            dgvLocal.DataSource = clsDetainedLicense.GetAllDetainedLicenses();
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

                case "DetainID":
                case "LicenseID":

                    mtbUsersFilterInput.Text = string.Empty;
                    mtbUsersFilterInput.Mask = "000000";
                    mtbUsersFilterInput.Focus();
                    break;

                case "LicenseStatus":
                    mtbUsersFilterInput.Visible = false;
                    cbUsersStatusOptions.Visible = true;
                    dgvLocal.DataSource = clsDetainedLicense.GetAllDetainedLicenses();
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
                case "DetainID":
                    if (int.TryParse(input, out int id))
                    {
                        dgvLocal.DataSource = clsDetainedLicense.GetAllDetainedLicensesByID(id);
                    }
                    break;


                case "LicenseID":
                    if (int.TryParse(input, out int localid))
                    {
                        dgvLocal.DataSource = clsDetainedLicense.GetAllDetainedLicensesByLicenseID(localid);
                    }
                    break;

                case "NationalNumber":

                    {
                        dgvLocal.DataSource = clsDetainedLicense.GetAllDetainedLicensesByNationalNumber(input);
                    }
                    break;




            }


            dgvLocal.Text = dgvLocal.RowCount.ToString();
        }

        private void showLicenseHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int licenseid = (int)dgvLocal.CurrentRow.Cells[3].Value;

            int applicationid = clsLicense.GetLicense(licenseid).ApplicationID;

            int personid = clsApplication.GetApplicationByID(applicationid).ApplicantPersonID;


            frmShowLicenseHistory frm = new(personid);
            frm.ShowDialog();
            _RefreshLocalList();
        }

        private void showLicenseStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicense frm = new((int)dgvLocal.CurrentRow.Cells[3].Value);
            frm.ShowDialog();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainReleaseLicenses frmDetainReleaseLicenses = new frmDetainReleaseLicenses(enLicenseMode.Detain);
            frmDetainReleaseLicenses.ShowDialog();
            _RefreshLocalList();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmDetainReleaseLicenses frmDetainReleaseLicenses = new frmDetainReleaseLicenses(enLicenseMode.Release);
            frmDetainReleaseLicenses.ShowDialog();
            _RefreshLocalList();
        }

        private void contextMenuStripLocal_Opening(object sender, CancelEventArgs e)
        {
            if (dgvLocal.CurrentRow.Cells[7].Value.ToString() == "False") //detained
            {
                releaseDetainLicenseToolStripMenuItem.Enabled = true;
            }
            else
            if (dgvLocal.CurrentRow.Cells[7].Value.ToString() == "True") //detained
            {
                releaseDetainLicenseToolStripMenuItem.Enabled = false;
            }
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainReleaseLicenses frmDetainReleaseLicenses = new frmDetainReleaseLicenses((int)dgvLocal.CurrentRow.Cells[3].Value, enLicenseMode.Release);
            frmDetainReleaseLicenses.ShowDialog();
            _RefreshLocalList();
        }
    }
}   

