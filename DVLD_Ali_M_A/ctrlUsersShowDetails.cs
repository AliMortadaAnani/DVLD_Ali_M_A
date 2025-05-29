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
using DVLD_General;
namespace DVLD_Presentation
{
    public partial class ctrlUsersShowDetails: UserControl
    {
        clsUser _User;
        public static int _UserID { get; set; }
        public ctrlUsersShowDetails()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                this.Load += ctrlUsersShowDetails_Load;
            }

        }

        private void ctrlUsersShowDetails_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                _LoadData();
        }

        private static string UserStatus(bool isactive)
        {
            if (isactive)
            {
                return "Active";
            }
            else
            {
                return "Not Active";
            }
        }


        public void _LoadData()
        {
            if (_UserID <= 0)
            {
               
                return;
            }

            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                if (!this.DesignMode)
                {
                    MessageBox.Show("User with ID: " + _UserID + " not found.");
                    ParentForm?.Close(); // Safe null-check
                }
                return;
            }

            lblidtxt.Text = _User.ID.ToString();
            lblusernametxt.Text = _User.UserName;
     
            lblstatustxt.Text = UserStatus(_User.IsActive);
          

        }

    }
}
