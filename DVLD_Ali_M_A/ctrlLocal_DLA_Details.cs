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
using Microsoft.VisualBasic.ApplicationServices;

namespace DVLD_Presentation
{
    public partial class ctrlLocal_DLA_Details : UserControl
    {
        public int _LocalDLA_ID { get; set; }
        clsLocal_DLA _LocalDLA;
        public ctrlLocal_DLA_Details()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.Load += ctrlLocal_DLA_Details_Load;
            }
        }

        private void ctrlLocal_DLA_Details_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                _LoadData();
        }

        public void _LoadData()
        {
            if (_LocalDLA_ID <= 0)
            {

                return;
            }
            _LocalDLA = clsLocal_DLA.GetLocalDLAByID(_LocalDLA_ID);
            if (_LocalDLA == null)
            {
                if (!this.DesignMode)
                {
                    MessageBox.Show("Local DLA with ID: " + _LocalDLA_ID + " not found.");
                }
                return;
            }
            lblidtxt.Text = _LocalDLA.ID.ToString();
            lblteststxt.Text = clsLocal_DLA.GetLocalDLA_PassedTests(_LocalDLA.ID).ToString() + "/3";
            lblclasstxt.Text = clsLicenseClass.Find(_LocalDLA.LicenseClassID).ClassName.ToString();


        }

    }
}
