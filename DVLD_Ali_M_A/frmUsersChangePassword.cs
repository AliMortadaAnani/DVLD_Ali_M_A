using DVLD_Business;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Presentation
{
    public partial class frmUsersChangePassword : Form
    {

        public static int _UserID;
        clsUser _User;


        public frmUsersChangePassword(int UserID)
        {
            InitializeComponent();
            ctrlUsersShowDetails._UserID = UserID;
            _UserID = UserID;
        }

        private void frmUsersChangePassword_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);

            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No user with ID = " + _UserID);
                ParentForm?.Close(); // Safe null-check

                return;
            }

        }

        private void btnPeopleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(tbnewpassword.Text) ||
                string.IsNullOrWhiteSpace(tbpassword.Text) ||
                string.IsNullOrWhiteSpace(tbpasswordconfirm.Text))
            {
                MessageBox.Show("Enter data correctly (fill required fields)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(errorProvider1.GetError(tbpassword))
                ||
                !string.IsNullOrEmpty(errorProvider1.GetError(tbnewpassword))
                || !string.IsNullOrEmpty(errorProvider1.GetError(tbpasswordconfirm)))
            {


                MessageBox.Show("Please enter data correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            _User.Password = tbnewpassword.Text.Trim();



            if (_User.Save())
                MessageBox.Show("User Saved Successfully.");
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
                return;
            }
        }



        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            Krypton.Toolkit.KryptonTextBox tbfield = (Krypton.Toolkit.KryptonTextBox)sender;
            tbfield.UseSystemPasswordChar = true;
        }

        private void tbpassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbpassword.Text.Trim() == "")
            {
                //tbpassword.Focus();
                errorProvider1.SetError(tbpassword, "Password is required!");
            }

            else if (tbpassword.Text.Trim() != _User.Password)
            {
                //  tbpassword.Focus();
                errorProvider1.SetError(tbpassword, "Password is incorrect!");
            }
            else
            {
                errorProvider1.SetError(tbpassword, "");
            }
        }

        private void tbnewpassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbnewpassword.Text.Trim() == "")
            {
                // tbnewpassword.Focus();
                errorProvider1.SetError(tbnewpassword, "New Password is required!");
            }
            else
            {
                errorProvider1.SetError(tbnewpassword, "");
            }

        }

        private void tbpasswordconfirm_Validating(object sender, CancelEventArgs e)
        {
            if (tbpasswordconfirm.Text.Trim() == "")
            {
                // tbpasswordconfirm.Focus();
                errorProvider1.SetError(tbpasswordconfirm, "Password confirmation is required!");
            }
            else if (tbnewpassword.Text.Trim() != tbpasswordconfirm.Text.Trim())
            {
                // tbpasswordconfirm.Focus();
                errorProvider1.SetError(tbpasswordconfirm, "Password confirmation is incorrect!");
            }
            else
            {
                errorProvider1.SetError(tbpasswordconfirm, "");
            }
        }

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            string documentation = "This form allows you to change your user password.\nYou must enter your current password correctly.\nThen enter the new password and confirm it.\nUse the Save button to apply the changes.";
            frmDocumentation frmDocumentation = new frmDocumentation(documentation);
            frmDocumentation.ShowDialog();

        }
    }
}
