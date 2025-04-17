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
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace DVLD_Presentation
{
    public partial class ctrlPeopleAddUpdate : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        public static int _PersonID;
        clsPeople _Person;

        public ctrlPeopleAddUpdate()
        {
            InitializeComponent();

            // Protect against crashing in design mode // GPT
            if (!this.DesignMode)
            {
                this.Load += ctrlPeopleAddUpdate_Load;
            }
        }

        private void ctrlPeopleAddUpdate_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (_PersonID == -1)
                    _Mode = enMode.AddNew;
                else
                    _Mode = enMode.Update;


                _FillCountriesInComoboBox();
                cbCountries.SelectedIndex = 0;

                dateofbirth.MaxDate = DateTime.Now - new TimeSpan(365 * 18, 0, 0, 0); // Set max date to 18 years ago

                if (_Mode == enMode.AddNew)
                {
                    _Person = new clsPeople();
                    return;
                }

                _Person = clsPeople.Find(_PersonID);

                if (_Person == null)
                {
                    MessageBox.Show("No person with ID = " + _PersonID);
                    ParentForm?.Close(); // Safe null-check

                    return;
                }

                lblid.Enabled = true;
                lblPid.Enabled = true;
                lblPid.Text = _Person.ID.ToString();


                tbfname.Text = _Person.FirstName;
                tbsname.Text = _Person.SecondName;
                tbtname.Text = _Person.ThirdName;
                tblname.Text = _Person.LastName;


                tbphone.Text = _Person.Phone;
                tbaddress.Text = _Person.Address;
                tbnationalnb.Text = _Person.NationalNb;
                tbemail.Text = _Person.Email;
                dateofbirth.Value = _Person.DateOfBirth;

                if (_Person.Gender == DVLD_DataTypes.enGender.Male)
                {
                    rbmale.Checked = true;
                }
                else
                {
                    rbfemale.Checked = true;

                }
                if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))
                {
                    string imagesFolder = Path.Combine("C:\\Users\\Ali\\Downloads", "AppImages");
                    string imagePath = Path.Combine(imagesFolder, _Person.ImagePath);
                    pbPeopleDetails.Load(imagePath);

                }
                else
                {
                    if (rbfemale.Checked == true)
                        pbPeopleDetails.Image = Resources.female;
                }


                if (_Person.ImagePath != "")
                {
                    
                    string imagesFolder = Path.Combine("C:\\Users\\Ali\\Downloads", "AppImages");
                    string imagePath = Path.Combine(imagesFolder, _Person.ImagePath);


                    pbPeopleDetails.Load(imagePath);
                }

                btnPeopleRemoveImage.Visible = (_Person.ImagePath != "");

                //this will select the country in the combobox.
                cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(_Person.NationalCountryID).CountryName);


            }
        }




        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                cbCountries.Items.Add(row["CountryName"]);

            }

        }

        private void btnPeopleSave_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountry.Find(cbCountries.Text).ID;

            _Person.FirstName = tbfname.Text;
            _Person.SecondName = tbsname.Text;
            _Person.ThirdName = tbtname.Text;
            _Person.LastName = tblname.Text;
            _Person.NationalNb = tbnationalnb.Text;
            _Person.NationalCountryID = CountryID;

            if (rbmale.Checked)
                _Person.Gender = DVLD_DataTypes.enGender.Male;
            else
                _Person.Gender = DVLD_DataTypes.enGender.Female;

            _Person.Email = tbemail.Text;
            _Person.Phone = tbphone.Text;
            _Person.Address = tbaddress.Text;
            _Person.DateOfBirth = dateofbirth.Value;


            if (pbPeopleDetails.ImageLocation != null)
            {

                _Person.ImagePath = Path.GetFileName(pbPeopleDetails.ImageLocation);

            }



            else
                _Person.ImagePath = "";

            if (_Person.Save())
                MessageBox.Show("Person Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;

            lblPid.Enabled = true;
            lblid.Enabled = true;
            lblPid.Text = _Person.ID.ToString();
        }

        private void btnPeopleClose_Click(object sender, EventArgs e)
        {
            ParentForm?.Close();
        }


        private void btnPeopleSetImage_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                // Step 1: Create target folder if not exists
                string imagesFolder = Path.Combine("C:\\Users\\Ali\\Downloads", "AppImages");
                Directory.CreateDirectory(imagesFolder);

                // Step 2: Generate unique name
                // string imageGuid = Guid.NewGuid().ToString();
                string imageGuid = clsPeople.GetGuid();
                string ext = Path.GetExtension(selectedFilePath); // e.g. .jpg

                string newFileName = imageGuid + ext;
                string newPath = Path.Combine(imagesFolder, newFileName);

                // Step 3: Copy image
                File.Copy(selectedFilePath, newPath);

                // Step 4: Load into PictureBox
                pbPeopleDetails.ImageLocation = newPath;

            }


            

        }


        private void btnPeopleRemoveImage_Click(object sender, EventArgs e)
        {
            pbPeopleDetails.ImageLocation = null;
            btnPeopleRemoveImage.Visible = false;
        }

        private void tbemail_Validating(object sender, CancelEventArgs e)
        {
            string email = tbemail.Text.Trim();

            // Simple and realistic email pattern
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            /*if (string.IsNullOrWhiteSpace(email))
            {
                e.Cancel = true;
                tbemail.Focus();
                errorProvider1.SetError(tbemail, "Email should not be empty!");
            }
            else */
            if (!Regex.IsMatch(email, pattern))
            {
                e.Cancel = true;
                tbemail.Focus();
                errorProvider1.SetError(tbemail, "Invalid email format!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbemail, "");
            }



        }
    }
}
