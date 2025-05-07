using DVLD_Business;
using DVLD_Presentation;



namespace DVLD_Ali_M_A
{
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084); // Fixed size
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);

            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            _RefreshPeopleList();
            _RefreshFilterInput();
            //mtbPeopleFilterInput.Visible = true; // Hide the input field initially
        }

        private void btnPeopleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshPeopleList()
        {
            dgvPeople.DataSource = clsPeople.GetAllPeople();
            lblPeopleTotalRecordsNb.Text = clsPeople.GetPeopleCount().ToString();
        }
        private void _RefreshFilterInput()
        {
            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("None"))
            {
                mtbPeopleFilterInput.Visible = false;
            }
        }




        private void cbPeopleFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("None"))
            {
                mtbPeopleFilterInput.Visible = false;
                _RefreshPeopleList();

            }
            else if
             (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("ID")
             || cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("YearOfBirth") // Add other filter types that require a mask here
             )
            {

                mtbPeopleFilterInput.Text = string.Empty; // Clear the input field
                mtbPeopleFilterInput.Visible = true;
                mtbPeopleFilterInput.Mask = "000000";
                mtbPeopleFilterInput.Focus(); // Set focus to the input field
            }
            else
            {
                mtbPeopleFilterInput.Text = string.Empty; // Clear the input field
                mtbPeopleFilterInput.Visible = true;
                mtbPeopleFilterInput.Mask = null;
                mtbPeopleFilterInput.Focus(); // Set focus to the input field
            }
        }

        private void mtbPeopleFilterInput_TextChanged(object sender, EventArgs e)
        {
            string input = mtbPeopleFilterInput.Text.Trim();

            string selectedFilter = cbPeopleFilterBox.Text;

            switch (selectedFilter)
            {
                case "ID":
                    if (int.TryParse(input, out int id))
                    {
                        dgvPeople.DataSource = clsPeople.GetPeopleByID(id);
                    }
                    break;

                case "NationalNumber":
                    dgvPeople.DataSource = clsPeople.GetPeopleByNationalNb(input);
                    break;

                case "FirstName":
                    dgvPeople.DataSource = clsPeople.GetPeopleByFirstName(input);
                    break;

                case "SecondName":
                    dgvPeople.DataSource = clsPeople.GetPeopleBySecondName(input);
                    break;

                case "LastName":
                    dgvPeople.DataSource = clsPeople.GetPeopleByLastName(input);
                    break;

                case "Nationality":
                    dgvPeople.DataSource = clsPeople.GetPeopleByNationality(input);
                    break;

                case "Gender":
                    dgvPeople.DataSource = clsPeople.GetPeopleByGender(input);
                    break;

                case "YearOfBirth":
                    if (int.TryParse(input, out int year))
                    {
                        dgvPeople.DataSource = clsPeople.GetPeopleByDateOfBirth(year.ToString());
                    }
                    break;

                case "Address":
                    dgvPeople.DataSource = clsPeople.GetPeopleByAddress(input);
                    break;

                case "Phone":
                    dgvPeople.DataSource = clsPeople.GetPeopleByPhone(input);
                    break;

                case "Email":
                    dgvPeople.DataSource = clsPeople.GetPeopleByEmail(input);
                    break;


            }


            lblPeopleTotalRecordsNb.Text = dgvPeople.RowCount.ToString();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete person with id : " + dgvPeople.CurrentRow.Cells[0].Value + "", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPeople.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.");
                    _RefreshPeopleList();
                }

                else
                    MessageBox.Show("Person is not deleted because it's linked to other data.");

            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleShowDetails frmPeopleShowDetails = new frmPeopleShowDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frmPeopleShowDetails.ShowDialog();
            _RefreshPeopleList();
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleAddUpdate frmPeopleAddUpdate = new frmPeopleAddUpdate((int)dgvPeople.CurrentRow.Cells[0].Value);
            frmPeopleAddUpdate.ShowDialog();
            _RefreshPeopleList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPeopleAddUpdate frmPeopleAddUpdate = new frmPeopleAddUpdate(-1);
            frmPeopleAddUpdate.ShowDialog();
            _RefreshPeopleList();

        }

        private void btnPeopleAddNew_Click(object sender, EventArgs e)
        {
            frmPeopleAddUpdate frmPeopleAddUpdate = new frmPeopleAddUpdate(-1);
            frmPeopleAddUpdate.ShowDialog();
            _RefreshPeopleList();
        }

        private void frmPeople_Deactivate(object sender, EventArgs e)
        {
            // this.Close();
            //this.ActiveControl = null; // Remove focus from any control
        }

        private void contextMenuStripPeople_Click(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStripPeople_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*if ((int)dgvPeople.CurrentRow.Cells[0].Value == 1)
            {
                addNewPersonToolStripMenuItem.Enabled = false;
            }
            else
            {
                addNewPersonToolStripMenuItem.Enabled = true;
            }*/
        }
    }
}
