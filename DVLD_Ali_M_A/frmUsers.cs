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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);


            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _RefreshUsersList();
            _RefreshFilterInput();

        }

        private void btnUsersCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshUsersList()
        {
            dgvUsers.DataSource = clsUser.GetAllUsers();
            lblUsersTotalRecordsNb.Text = clsUser.GetUsersCount().ToString();
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

            switch (cbUsersFilterBox.SelectedItem?.ToString())
            {
                case "None":
                    mtbUsersFilterInput.Visible = false;
                    _RefreshUsersList();
                    break;

                case "ID":
                case "PersonID":
                    mtbUsersFilterInput.Text = string.Empty;
                    mtbUsersFilterInput.Mask = "000000";
                    mtbUsersFilterInput.Focus();
                    break;

                case "Status":
                    mtbUsersFilterInput.Visible = false;
                    cbUsersStatusOptions.Visible = true;
                    dgvUsers.DataSource = clsUser.GetAllUsers();
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
                case "ID":
                    if (int.TryParse(input, out int id))
                    {
                        dgvUsers.DataSource = clsUser.GetUsersByID(id);
                    }
                    break;


                case "PersonID":
                    if (int.TryParse(input, out int personID))
                    {
                        dgvUsers.DataSource = clsUser.GetUsersByPersonID(personID);
                    }
                    break;

                case "Username":
                    dgvUsers.DataSource = clsUser.GetUsersByUserName(input);
                    break;

                case "FirstName":
                    dgvUsers.DataSource = clsUser.GetUsersByFirstName(input);
                    break;

                case "LastName":
                    dgvUsers.DataSource = clsUser.GetUsersByLastName(input);
                    break;



            }


            lblUsersTotalRecordsNb.Text = dgvUsers.RowCount.ToString();
        }

        private void cbUsersStatusOptions_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (cbUsersStatusOptions.SelectedItem?.ToString())
            {
                case "All":
                    dgvUsers.DataSource = clsUser.GetAllUsers();
                    break;


                case "Active":
                    dgvUsers.DataSource = clsUser.GetUsersByIsActive("Active");
                    break;

                case "Not Active":
                    dgvUsers.DataSource = clsUser.GetUsersByIsActive("Not Active");
                    break;
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete user with id : " + dgvUsers.CurrentRow.Cells[0].Value + "", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _RefreshUsersList();
                }

                else
                    MessageBox.Show("User is not deleted because it's linked to other data.");

            }
        }

        private void btnUserAddNew_Click(object sender, EventArgs e)
        {
            frmUsersAddUpdate frmUsersAddUpdate = new frmUsersAddUpdate(-1, -1);
            frmUsersAddUpdate.ShowDialog();
            _RefreshUsersList();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersAddUpdate frmUsersAddUpdate = new frmUsersAddUpdate(-1, -1);
            frmUsersAddUpdate.ShowDialog();
            _RefreshUsersList();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersAddUpdate frmUsersAddUpdate = new frmUsersAddUpdate((int)dgvUsers.CurrentRow.Cells[1].Value, (int)dgvUsers.CurrentRow.Cells[0].Value);
            frmUsersAddUpdate.ShowDialog();
            _RefreshUsersList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersShowDetails frmUsersShowDetails = new frmUsersShowDetails((int)dgvUsers.CurrentRow.Cells[1].Value, (int)dgvUsers.CurrentRow.Cells[0].Value);
            frmUsersShowDetails.ShowDialog();
            _RefreshUsersList();
        }
    }
}
