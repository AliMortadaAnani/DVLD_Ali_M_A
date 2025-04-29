using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD_Presentation
{
    public partial class ctrlPersonFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSearchComplete;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSearchComplete(int PersonID)
        {
            Action<int> handler = OnPersonSearchComplete;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }
        public ctrlPersonFilter()
        {
            InitializeComponent();
        }

        private void cbPersonFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if
             (cbPersonFilterBox.Text == "PersonID")
            {

                mtbPersonFilterInput.Text = string.Empty; // Clear the input field
                mtbPersonFilterInput.Visible = true;
                mtbPersonFilterInput.Mask = "000000";
                mtbPersonFilterInput.Focus(); // Set focus to the input field
            }
            else
            {
                mtbPersonFilterInput.Text = string.Empty; // Clear the input field
                mtbPersonFilterInput.Visible = true;
                mtbPersonFilterInput.Mask = null;
                mtbPersonFilterInput.Focus(); // Set focus to the input field
            }
        }

        private void btnPersonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbPersonFilterInput.Text))
            {
                MessageBox.Show("Please enter a value in the filter input.");
                return;
            }
            string selectedFilter = cbPersonFilterBox.Text;
            string input = mtbPersonFilterInput.Text.Trim();
            switch (selectedFilter)
            {
                case "PersonID":
                    if (int.TryParse(input, out int id))
                    {
                        if (clsPeople.IsPersonExist(id))
                        {
                            if (OnPersonSearchComplete != null)
                                // Raise the event with a parameter
                                OnPersonSearchComplete(id);
                        }
                        else
                        {
                            MessageBox.Show("Person with this ID does not exist.");
                        }
                    }
                    break;

                case "NationalNumber":
                    if (clsPeople.IsNationalNumberExist(input))
                    {
                        clsPeople person = clsPeople.Find(input);
                        if (OnPersonSearchComplete != null && person is not null)
                            // Raise the event with a parameter
                            OnPersonSearchComplete(person.ID);
                    }
                    else
                    {
                        MessageBox.Show("Person with this National Number does not exist.");
                    }
                    break;
            }
        }

        private void mtbPersonFilterInput_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnPersonAddNew_Click(object sender, EventArgs e)
        {
            frmPeopleAddUpdate frmPeopleAddUpdate = new frmPeopleAddUpdate(-1);
           
            frmPeopleAddUpdate.ShowDialog();

            if (OnPersonSearchComplete != null && (frmPeopleAddUpdate._PersonID_Back != -1
                && frmPeopleAddUpdate._PersonID_Back != 0))
                // Raise the event with a parameter
                OnPersonSearchComplete(frmPeopleAddUpdate._PersonID_Back);


        }
    }
}
