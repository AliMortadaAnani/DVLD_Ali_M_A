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
    public partial class frmLocalDLA_Main : frmGeneral
    {
        public frmLocalDLA_Main()
        {
            InitializeComponent();

        }

        private void frmLocalDLA_Main_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);


            dgvLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _RefreshLocalList();
            _RefreshFilterInput();
        }


        private void _RefreshLocalList()
        {
            dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA();
            lblLocalTotalRecordsNb.Text = dgvLocal.RowCount.ToString();
        }
        private void _RefreshFilterInput()
        {
            if (cbLocalFilterBox.SelectedIndex == cbLocalFilterBox.FindString("None"))
            {
                mtbLocalFilterInput.Visible = false;
                cbLocalStatusOptions.Visible = false;
            }
        }







        /*private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete user with id : " + dgvUsers.CurrentRow.Cells[0].Value + "", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _RefreshLocalList();
                }

                else
                    MessageBox.Show("User is not deleted because it's linked to other data.");

            }
        }*/





        private void cbLocalFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLocalStatusOptions.Visible = false;
            cbLocalStatusOptions.SelectedIndex = cbLocalStatusOptions.FindString("All");
            mtbLocalFilterInput.Visible = true;

            switch (cbLocalFilterBox.SelectedItem?.ToString())
            {
                case "None":
                    mtbLocalFilterInput.Visible = false;
                    _RefreshLocalList();
                    break;

                case "ID":

                    mtbLocalFilterInput.Text = string.Empty;
                    mtbLocalFilterInput.Mask = "000000";
                    mtbLocalFilterInput.Focus();
                    break;

                case "Status":
                    mtbLocalFilterInput.Visible = false;
                    cbLocalStatusOptions.Visible = true;
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA();
                    break;

                default:
                    mtbLocalFilterInput.Text = string.Empty;
                    mtbLocalFilterInput.Mask = null;
                    mtbLocalFilterInput.Focus();
                    break;
            }
        }



        private void cbLocalStatusOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLocalStatusOptions.SelectedItem?.ToString())
            {
                case "All":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA();
                    break;


                case "New":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByStatus("New");
                    break;

                case "Cancelled":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByStatus("Cancelled");
                    break;

                case "Completed":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByStatus("Completed");
                    break;
            }
            lblLocalTotalRecordsNb.Text = dgvLocal.RowCount.ToString();
        }

        private void mtbLocalFilterInput_TextChanged(object sender, EventArgs e)
        {
            string input = mtbLocalFilterInput.Text.Trim();

            string selectedFilter = cbLocalFilterBox.Text;

            switch (selectedFilter)
            {
                case "ID":
                    if (int.TryParse(input, out int id))
                    {
                        dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByID(id);
                    }
                    break;




                case "NationalNumber":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByNationalNb(input);
                    break;

                case "FullName":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByFulllName(input);
                    break;

                case "Status":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByStatus(input);
                    break;

            }
            lblLocalTotalRecordsNb.Text = dgvLocal.RowCount.ToString();
        }

        private void CancelApplicationtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLocal.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to Cancel local application with id : " + id + "", "Confirm Cancellation", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {
                
                enApplicationStatus status = clsLocal_DLA.GetLocalDLA_Status(id);

                if (status == enApplicationStatus.New)
                {
                    clsLocal_DLA.UpdateLocalDLA_Status(id,enApplicationStatus.Cancelled);
                    clsApplication.UpdateApplicationLastStatusDate(clsLocal_DLA.GetLocalDLAByID(id).ApplicationID, DateTime.Now);
                    MessageBox.Show("Application Cancelled Successfully.");
                    _RefreshLocalList();
                }
                else
                    MessageBox.Show("Application cannot be cancelled.");



            }
        }

        private void btnLocalAddNew_Click(object sender, EventArgs e)
        {
            frmLocal_DLA_AddUpdate frm = new frmLocal_DLA_AddUpdate(-1, -1);
            frm.ShowDialog();
            _RefreshLocalList();
        }

        private void addNewLocalDLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocal_DLA_AddUpdate frm = new frmLocal_DLA_AddUpdate(-1, -1);
            frm.ShowDialog();
            _RefreshLocalList();
        }

        private void updateApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            string nationalNb = dgvLocal.CurrentRow.Cells[2].Value.ToString();
            int id = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int personId = clsPeople.Find(nationalNb).ID;


            enApplicationStatus status = clsLocal_DLA.GetLocalDLA_Status(id);

            if (status == enApplicationStatus.New)
            {
                frmLocal_DLA_AddUpdate frm = new frmLocal_DLA_AddUpdate(personId, id);
                frm.ShowDialog();
                _RefreshLocalList();
            }
            else
                MessageBox.Show("Application cannot be updated.");
        }
    }
}
