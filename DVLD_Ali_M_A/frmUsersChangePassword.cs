using DVLD_Business;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmUsersChangePassword : Form
    {

        public static int _UserID;
        clsUser _User;
        

        public frmUsersChangePassword(int UserID)
        {
            InitializeComponent();
            ctrlUsersShowDetails._UserID = UserID;
        }

        private void frmUsersChangePassword_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void btnPeopleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
