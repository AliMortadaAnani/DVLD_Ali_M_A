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
    public partial class frmLocal_DLA_ShowDetails: frmGeneral
    {
        public frmLocal_DLA_ShowDetails(int LocalID,int AppID)
        {
            InitializeComponent();
            lblGeneralTitle.Text = "Driving License Application Details";
            ctrlLocal_dlA_Details1._LocalDLA_ID = LocalID;
            ctrlApplicationShow1._ApplicationID = AppID;
        }
    }
}
