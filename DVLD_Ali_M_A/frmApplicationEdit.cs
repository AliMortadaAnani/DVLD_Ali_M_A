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
    public partial class frmApplicationEdit : Form
    {
        int _ID { get; set; }
        clsApplicationType _applicationType;
        public frmApplicationEdit(int ID)
        {
            InitializeComponent();
            _ID = ID;

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApplicationEdit_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084); // Fixed size
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            _applicationType = clsApplicationType.GetByID(_ID);
            if (_applicationType == null)
            {
                MessageBox.Show("Application Type Not Found");
                this.Close();
            }
            else
            {
                lblidnb.Text = _applicationType.ID.ToString();
                tbtitle.Text = _applicationType.Title;
                tbfees.Text = _applicationType.Fees.ToString();

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
            _applicationType.Title = tbtitle.Text.Trim();
            _applicationType.Fees = int.Parse(tbfees.Text.Trim());
            
            if (_applicationType.Save())
            {
                MessageBox.Show("Application Type Updated");
                
            }
            else
            {
                MessageBox.Show("Application Type Not Updated");
            }
        }
    }
}
