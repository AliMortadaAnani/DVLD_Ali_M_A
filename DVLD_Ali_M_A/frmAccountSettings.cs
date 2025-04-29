using DVLD_Business;
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
        public frmMenu frmMenu;

        public frmAccountSettings(frmMenu frmMenu)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
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
            clsGlobalUser.CurrentUser = null; // Clear the current user
            clsGlobalUser.SaveUserIdToFile(-1); // Clear the saved user ID
            
            this.Close(); // Close the settings form
            frmMenu?.Close(); // Close the menu form    
           


        }
    }
}
