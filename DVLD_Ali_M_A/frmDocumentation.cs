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
    public partial class frmDocumentation: frmGeneral
    {
        public frmDocumentation(string Documentation)
        {
            InitializeComponent();
            lblGeneralTitle.Text = "About This Form";
            rtbDocumentation.Text = Documentation;
        }
    }
}
