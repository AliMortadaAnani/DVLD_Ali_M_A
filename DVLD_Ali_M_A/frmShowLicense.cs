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
    public partial class frmShowLicense: frmGeneral
    {
        public frmShowLicense(int licenseid)
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Driver License Information";
            ctrlLicenseInfo1._LicenseID = licenseid;
        }
    }
}
