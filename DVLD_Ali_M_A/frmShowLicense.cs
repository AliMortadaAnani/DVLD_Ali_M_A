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
    public partial class frmShowLicense : frmGeneral
    {
        public frmShowLicense(int licenseid)
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Driver License Information";
            ctrlLicenseInfo1._LicenseID = licenseid;
        }

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            string documentation = "This form displays detailed information about a local driving license.";
            frmDocumentation frmDocumentation = new frmDocumentation(documentation);
            frmDocumentation.ShowDialog();

        }
    }
}
