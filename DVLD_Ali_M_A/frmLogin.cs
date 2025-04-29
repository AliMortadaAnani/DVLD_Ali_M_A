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

namespace DVLD_Ali_M_A
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginPassword_TextChanged(object sender, EventArgs e)
        {
            tbLoginPassword.UseSystemPasswordChar = true;
        }


        private void LoginUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbLoginPassword.Focus();
                e.SuppressKeyPress = true;  // Prevent the "ding" sound
            }
        }

        private void LoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                cbLoginRememberMe.Focus();
                e.SuppressKeyPress = true;  // Prevent the "ding" sound
            }
        }

        private void LoginRememberMe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                btnLoginButton.Focus();
                e.SuppressKeyPress = true;  // Prevent the "ding" sound
            }
        }

        private void LoginButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                btnLoginButton.PerformClick();
                e.SuppressKeyPress = true;  // Prevent the "ding" sound
            }
        }

        private void RememberMe(bool RememberMe, int ID)
        {
            if (RememberMe)
            {
                clsGlobalUser.SaveUserIdToFile(ID);
            }
            else
            {
                clsGlobalUser.SaveUserIdToFile(-1);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = tbLoginUsername.Text.Trim();
            string password = tbLoginPassword.Text.Trim();




            if (clsUser.IsUserExist(username, password))
            {
                clsGlobalUser.CurrentUser = clsUser.FindCurrentUser(username, password);
                if (clsGlobalUser.CurrentUser.IsActive)
                {
                    RememberMe(cbLoginRememberMe.Checked, clsGlobalUser.CurrentUser.ID);
                    frmMenu frmMenu = new frmMenu(this);
                    frmMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This user is not active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbLoginUsername_Validating(object sender, CancelEventArgs e)
        {
            string username = tbLoginUsername.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                e.Cancel = true;
                tbLoginUsername.Focus();
                errorProvider1.SetError(tbLoginUsername, "Cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbLoginUsername, "");
            }
        }

        private void tbLoginPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = tbLoginPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                e.Cancel = true;
                tbLoginPassword.Focus();
                errorProvider1.SetError(tbLoginPassword, "Cannot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbLoginPassword, "");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (clsGlobalUser.ReadUserIdFromFile() != -1)
            {
                clsGlobalUser.CurrentUser = clsUser.Find(clsGlobalUser.ReadUserIdFromFile());
                tbLoginUsername.Text = clsGlobalUser.CurrentUser.UserName;
                tbLoginPassword.Text = clsGlobalUser.CurrentUser.Password;
                cbLoginRememberMe.Checked = true;
            }
            
        }
    }
}
