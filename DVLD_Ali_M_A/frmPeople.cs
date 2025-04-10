using DVLD_Business;
using DVLD_DataTypes;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



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

            // Move form to the right side of the screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            _RefreshPeopleList();
            _RefreshFilterInput();

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
                _RefreshFilterInput();
            }
            else if
             (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("ID"))
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


            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("ID"))
            {
               

                if (int.TryParse(input, out int id))
                {
                    dgvPeople.DataSource = clsPeople.GetPeopleByID(id);
                }
                
            }

            if(cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("NationalNumber"))
            {
               
                dgvPeople.DataSource = clsPeople.GetPeopleByNationalNb(input);
            }

            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("FirstName"))
            {
               
                dgvPeople.DataSource = clsPeople.GetPeopleByFirstName(input);
            }

            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("SecondName"))
            {
                
                dgvPeople.DataSource = clsPeople.GetPeopleBySecondName(input);
            }

            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("LastName"))
            {
                
                dgvPeople.DataSource = clsPeople.GetPeopleByLastName(input);
            }

            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("Nationality"))
            {
               

                /*if(clsCountry.Find(input) == null)
                {
                    
                    return;
                }

                int NationalityID = clsCountry.Find(input).ID;*/
               
                dgvPeople.DataSource = clsPeople.GetPeopleByNationality(input);
            }



            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("Gender"))
            {
               dgvPeople.DataSource = clsPeople.GetPeopleByGender(input);

            }

            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("DateOfBirth"))
            {

                dgvPeople.DataSource = clsPeople.GetPeopleByDateOfBirth(input);
            }

            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("Address"))
            {
                
                dgvPeople.DataSource = clsPeople.GetPeopleByAddress(input);
            }

            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("Phone"))
            {

                dgvPeople.DataSource = clsPeople.GetPeopleByPhone(input);
            }

            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("Email"))
            {

                dgvPeople.DataSource = clsPeople.GetPeopleByEmail(input);
            }

            lblPeopleTotalRecordsNb.Text = dgvPeople.RowCount.ToString();
        }
    }
}
