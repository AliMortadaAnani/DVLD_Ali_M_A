using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Ali_M_A
{
    public partial class frmAccountSettings : Form
    {
        public frmAccountSettings()
        {
            InitializeComponent();
        }

        private void SettingsCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmAccountSettings_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084); // Fixed size

            // Move form to the right side of the screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void SettingsSignOut_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("You have been signed out successfully.", "Sign Out", MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }
    }
}
