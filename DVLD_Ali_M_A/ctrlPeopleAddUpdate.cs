using DVLD_Business;
using DVLD_Presentation.Properties;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace DVLD_Presentation
{
    public partial class ctrlPeopleAddUpdate : UserControl
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private string _tempImagePath = "";
        private string newPath = "";
        private bool removeImage = false;
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

        public static string MyImage(string image)
        {
            string imagesFolder = Path.Combine("C:\\Users\\Ali\\Downloads", "AppImages");
            Directory.CreateDirectory(imagesFolder);
            string imagePath = Path.Combine(imagesFolder, image);
            return imagePath;
        }

        private void LoadNewPerson()
        {
            cbCountries.SelectedIndex = cbCountries.FindString("Lebanon");
            _Person = new clsPeople();
            return;
        }

        private void LoadExistingPerson(int _PersonID)
        {
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

            if (_Person.Gender == DVLD_General.enGender.Male)
            {
                rbmale.Checked = true;
            }
            else
            {
                rbfemale.Checked = true;

            }
            pbPeopleDetails.Visible = true;
            if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(MyImage(_Person.ImagePath)))
            {

                using (var img = System.Drawing.Image.FromFile(MyImage(_Person.ImagePath)))
                {
                    pbPeopleDetails.Image = new Bitmap(img); // Copy image, release lock
                }

            }
            else
            {
                if (rbfemale.Checked == true)
                    pbPeopleDetails.Image = Resources.female;
            }




            btnPeopleRemoveImage.Visible = (_Person.ImagePath != "");

            //this will select the country in the combobox.
            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(_Person.NationalCountryID).CountryName);


        }

        private void ctrlPeopleAddUpdate_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                _FillCountriesInComoboBox();
                dateofbirth.MaxDate = DateTime.Now - new TimeSpan(365 * 18, 0, 0, 0); // Set max date to 18 years ago

                if (_PersonID == -1)
                {
                    _Mode = enMode.AddNew;
                    LoadNewPerson();
                }
                else
                {
                    _Mode = enMode.Update;
                    LoadExistingPerson(_PersonID);

                }
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
            if (rbmale.Checked)
                _Person.Gender = DVLD_General.enGender.Male;
            else if (rbfemale.Checked)
                _Person.Gender = DVLD_General.enGender.Female;
            else
            {

                rbmale.Focus();
                errorProvider1.SetError(rbmale, "You should choose gender!");
                return;
            }
            errorProvider1.SetError(rbmale, "");

            int CountryID = clsCountry.Find(cbCountries.Text).ID;

            _Person.FirstName = tbfname.Text;
            _Person.SecondName = tbsname.Text;
            _Person.ThirdName = tbtname.Text;
            _Person.LastName = tblname.Text;
            _Person.NationalNb = tbnationalnb.Text;
            _Person.NationalCountryID = CountryID;


            _Person.Email = tbemail.Text;
            _Person.Phone = tbphone.Text;
            _Person.Address = tbaddress.Text;
            _Person.DateOfBirth = dateofbirth.Value;

            if (!string.IsNullOrEmpty(_tempImagePath) || removeImage == true)
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                if (File.Exists(MyImage(_Person.ImagePath)))
                {
                    File.SetAttributes(MyImage(_Person.ImagePath), FileAttributes.Normal);
                    File.Delete(MyImage(_Person.ImagePath));
                }
                _Person.ImagePath = _tempImagePath;

            }

            _tempImagePath = "";





            if (_Person.Save())
               {

                // Trigger the event to send data back to Form1
                DataBack?.Invoke(this, _Person.ID);
                MessageBox.Show("Person Saved Successfully.");
                frmPeopleAddUpdate.lblPeopleTitle.Text = "Edit Person Details";

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;

            lblPid.Enabled = true;
            lblid.Enabled = true;
            lblPid.Text = _Person.ID.ToString();




        }

        private void btnPeopleClose_Click(object sender, EventArgs e)
        {
            if (_tempImagePath != _Person.ImagePath)
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                if (File.Exists(MyImage(_tempImagePath)))
                {
                    File.SetAttributes(MyImage(_tempImagePath), FileAttributes.Normal);
                    File.Delete(MyImage(_tempImagePath));
                }
                if (!_Person.ImagePath.Equals(""))
                {
                    btnPeopleRemoveImage.Visible = true;
                }
            }

            ParentForm?.Close();
        }


        private void btnPeopleSetImage_Click(object sender, EventArgs e)
        {
            removeImage = false;
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string selectedFilePath = openFileDialog1.FileName;

                string imageGuid = clsPeople.GetGuidForImageName();
                string ext = Path.GetExtension(selectedFilePath); // e.g. .jpg

                string newFileName = imageGuid + ext;

                newPath = MyImage(newFileName);


                File.Copy(selectedFilePath, newPath);


                using (var img = System.Drawing.Image.FromFile(newPath))
                {
                    pbPeopleDetails.Image = new Bitmap(img); // Copy image, release lock
                }
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                if (File.Exists(MyImage(_tempImagePath)))
                {
                    File.SetAttributes(MyImage(_tempImagePath), FileAttributes.Normal);
                    File.Delete(MyImage(_tempImagePath));
                }

                _tempImagePath = newFileName;
                pbPeopleDetails.Visible = true;
                btnPeopleRemoveImage.Visible = true;
            }




        }


        private void btnPeopleRemoveImage_Click(object sender, EventArgs e)
        {
            removeImage = true;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            if (File.Exists(MyImage(_tempImagePath)))
            {
                File.SetAttributes(MyImage(_tempImagePath), FileAttributes.Normal);
                File.Delete(MyImage(_tempImagePath));
            }
            pbPeopleDetails.Visible = false;
            pbPeopleDetails.ImageLocation = null;
            btnPeopleRemoveImage.Visible = false;
            _tempImagePath = "";
        }

        private void tbemail_Validating(object sender, CancelEventArgs e)
        {
            string email = tbemail.Text.Trim();

            // Simple and realistic email pattern
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrWhiteSpace(email))
            {
                e.Cancel = false;
                errorProvider1.SetError(tbemail, "");
            }
            else
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

        private void tbnationalnb_Validating(object sender, CancelEventArgs e)
        {
           // if (_Mode == enMode.AddNew)
            {
                string nationalnb = tbnationalnb.Text.Trim();

                if (clsPeople.IsNationalNumberExist(nationalnb) && nationalnb != _Person.NationalNb)
                {
                    e.Cancel = true;
                    tbnationalnb.Focus();
                    errorProvider1.SetError(tbnationalnb, "This national number already exists!");
                }
                else if (string.IsNullOrWhiteSpace(nationalnb))
                {
                    e.Cancel = true;
                    tbnationalnb.Focus();
                    errorProvider1.SetError(tbnationalnb, "Cannot be null!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbnationalnb, "");
                }
            }

        }

        private void RequiredField_Validating(object sender, CancelEventArgs e)
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

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {
            if (_Person.ImagePath == "")
            {
                pbPeopleDetails.Image = Resources.male3;
            }

        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {
            if (_Person.ImagePath == "")
            {
                pbPeopleDetails.Image = Resources.female;
            }
        }
    }
}
