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
    public partial class test1: Form
    {
        int idd { get; set; }
        public test1(int id)
        {
            idd = id;
            InitializeComponent();
        }
    }
}
