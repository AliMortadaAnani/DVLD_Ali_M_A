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
using DVLD_Presentation.Properties;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_Presentation
{
    public partial class ctrlUsersAddUpdate : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public static int _UserID;
        clsUser _User;
        public ctrlUsersAddUpdate()
        {
            InitializeComponent();
            // Protect against crashing in design mode // GPT
            if (!this.DesignMode)
            {
                this.Load += ctrlUsersAddUpdate_Load;
            }
        }

        private void ctrlUsersAddUpdate_Load(object? sender, EventArgs e)
        {
            if (!this.DesignMode)
            {

                if (_UserID == -1)
                {
                    _Mode = enMode.AddNew;
                    LoadNewUser();
                }
                else
                {
                    _Mode = enMode.Update;
                    LoadExistingUser(_UserID);

                }
            }
        }

        private void LoadNewUser()
        {
            lblid.Enabled = false;
            lbluserid.Visible = false;
            _User = new clsUser();
            return;
        }
        private void LoadExistingUser(int _UserID)
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No user with ID = " + _UserID);
                ParentForm?.Close(); // Safe null-check

                return;
            }

            lblid.Enabled = true;
            lbluserid.Visible = true;
            lbluserid.Text = _User.ID.ToString();


            tbpassword.Text = _User.Password;
            tbpasswordconfirm.Text = _User.Password;
            tbusername.Text = _User.UserName;
            cbisactive.Checked = _User.IsActive;




        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            tbpassword.UseSystemPasswordChar = true;
        }

        private void tbpasswordconfirm_TextChanged(object sender, EventArgs e)
        {
            tbpasswordconfirm.UseSystemPasswordChar = true;
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
              if (tbpassword.Text.Trim() != tbpasswordconfirm.Text.Trim())
            {
               
                tbpasswordconfirm.Focus();
                errorProvider1.SetError(tbpasswordconfirm, "Password confirmation is incorrect!");
            }

            _User.IsActive = (cbisactive.Checked);
            _User.PersonID = ctrlPeopleShowDetails._PersonID;

            _User.UserName = tbusername.Text.Trim();
            _User.Password = tbpassword.Text.Trim();


            
            if (_User.Save())
                MessageBox.Show("User Saved Successfully.");
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
                return;
            }

            _Mode = enMode.Update;


            lblid.Enabled = true;
            lbluserid.Visible = true;
            lbluserid.Text = _User.ID.ToString();



        }

        private void tbusername_Validating(object sender, CancelEventArgs e)
        {
            //if (_Mode == enMode.AddNew)
            {
                string username = tbusername.Text.Trim();

                if (clsUser.IsUsernameExist(username) && username != _User.UserName)
                {
                    e.Cancel = true;
                    tbusername.Focus();
                    errorProvider1.SetError(tbusername, "This username already exists!");
                }
                else if (string.IsNullOrWhiteSpace(username))
                {
                    e.Cancel = true;
                    tbusername.Focus();
                    errorProvider1.SetError(tbusername, "Cannot be null!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbusername, "");
                }
            }
        }

        private void tbpassword_Validating(object sender, CancelEventArgs e)
        {
            string password = tbpassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(password))
            {
                e.Cancel = true;
                tbpassword.Focus();
                errorProvider1.SetError(tbpassword, "Cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbpassword, "");
            }
        }

        private void tbpasswordconfirm_Validating(object sender, CancelEventArgs e)
        {
            string passwordconfirmation = tbpasswordconfirm.Text.Trim();
            string password = tbpassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(passwordconfirmation))
            {
                e.Cancel = true;
                tbpassword.Focus();
                errorProvider1.SetError(tbpassword, "Cannot be null!");
            }
           
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbpasswordconfirm, "");
            }
        }

        private void tbpasswordconfirm_Validated(object sender, EventArgs e)
        {

        }
    }
}
