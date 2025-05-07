using DVLD_Business;
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
    public partial class frmTestEdit : Form
    {
        int _ID { get; set; }
        clsTestType _testType;
        public frmTestEdit(int ID)
        {
            InitializeComponent();
            _ID = ID;

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestEdit_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084); // Fixed size
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            _testType = clsTestType.GetByID(_ID);
            if (_testType == null)
            {
                MessageBox.Show("Test Type Not Found");
                
            }
            else
            {
                lblidnb.Text = _testType.ID.ToString();
                tbtitle.Text = _testType.Title;
                tbfees.Text = _testType.Fees.ToString();
                tbdescription.Text = _testType.Description;
            }
        }

        private void tbtitle_Validating(object sender, CancelEventArgs e)
        {
            Krypton.Toolkit.KryptonTextBox tbfield = (Krypton.Toolkit.KryptonTextBox)sender;
            string field = tbfield.Text.Trim();



            if (string.IsNullOrWhiteSpace(field))
            {

                e.Cancel = true;
                tbfield.Focus();
                errorProvider1.SetError(tbfield, "Cannot be null!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbfield, "");
            }

        }

        private void btnPeopleAddNew_Click(object sender, EventArgs e)
        {
            _testType.Title = tbtitle.Text.Trim();
            _testType.Fees = Decimal.Parse(tbfees.Text.Trim());
            _testType.Description = tbdescription.Text.Trim();
            if(_testType.Save())
            {
                MessageBox.Show("Test Type Updated");
               
            }
            else
            {
                MessageBox.Show("Test Type Not Updated");
            }
        }
    }
}
