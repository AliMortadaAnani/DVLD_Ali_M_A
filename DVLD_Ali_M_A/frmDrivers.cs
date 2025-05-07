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
    public partial class frmDrivers : frmGeneral
    {
        public frmDrivers()
        {
            InitializeComponent();
            lblGeneralTitle.Text = "List Of Drivers";

        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            _RefreshPeopleList();
            _RefreshFilterInput();
        }


        private void _RefreshPeopleList()
        {
            dgvPeople.DataSource = clsDriver.GetAllDrivers();
            lblPeopleTotalRecordsNb.Text = dgvPeople.Rows.Count.ToString();
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
            _RefreshPeopleList();

            if (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("None"))
            {
                mtbPeopleFilterInput.Visible = false;
                _RefreshPeopleList();

            }
            else if
             (cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("ID")
             || cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("YearOfBirth") 
             || cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("PersonID")
             || cbPeopleFilterBox.SelectedIndex == cbPeopleFilterBox.FindString("ActiveLicenses")
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
                        dgvPeople.DataSource = clsDriver.GetAllDriversByID(id);
                    }
                    break;

                case "PersonID":
                    if (int.TryParse(input, out int PersonID))
                    {
                        dgvPeople.DataSource = clsDriver.GetAllDriversByPersonID(PersonID);
                    }
                    break;

                case "ActiveLicenses":
                    if (int.TryParse(input, out int ActiveLicensesNumber))
                    {
                        dgvPeople.DataSource = clsDriver.GetAllDriversByLicensesNumber(ActiveLicensesNumber);
                    }
                    break;


                case "YearOfBirth":
                    if (int.TryParse(input, out int year))
                    {
                        dgvPeople.DataSource = clsDriver.GetAllDriversByIssueDate(year.ToString());
                    }
                    break;


                case "NationalNumber":
                    dgvPeople.DataSource = clsDriver.GetAllDriversByNationalNumber(input);
                    break;

                case "FullName":
                    dgvPeople.DataSource = clsDriver.GetAllDriversByFullName(input);
                    break;

               


                


            }


            lblPeopleTotalRecordsNb.Text = dgvPeople.RowCount.ToString();
        }



    }
}
