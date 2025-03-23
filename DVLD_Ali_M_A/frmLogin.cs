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
            LoginPassword.UseSystemPasswordChar = true;
        }


        private void LoginUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginPassword.Focus();
                e.SuppressKeyPress = true;  // Prevent the "ding" sound
            }
        }

        private void LoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                LoginRememberMe.Focus();
                e.SuppressKeyPress = true;  // Prevent the "ding" sound
            }
        }

        private void LoginRememberMe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                LoginButton.Focus();
                e.SuppressKeyPress = true;  // Prevent the "ding" sound
            }
        }

        private void LoginButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                LoginButton.PerformClick();
                e.SuppressKeyPress = true;  // Prevent the "ding" sound
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Successful");
        }
    }
}
