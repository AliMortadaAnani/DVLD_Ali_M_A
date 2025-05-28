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
using DVLD_General;
namespace DVLD_Presentation
{
    public partial class ctrlLicenseDetain: UserControl
    {   
        
        public enLicenseMode Mode;
        public ctrlLicenseDetain()
        {
            InitializeComponent();
        }
        // Define a custom event handler delegate with parameters
        public event Action<int> OnLicenseSearchComplete;
        // Create a protected method to raise the event with a parameter
        public virtual void LicenseSearchComplete(int LicenseID)
        {
            Action<int> handler = OnLicenseSearchComplete;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

        // 1. Change the delegate to Action (no parameters) instead of Action<int>
        public event Action OnLicenseSearchFail;

        // 2. Update the event-raising method to be parameterless
        protected virtual void LicenseSearchFailed()
        {
            // Using null-conditional operator (?.) for thread safety
            OnLicenseSearchFail?.Invoke();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbLicenseFilterInput.Text))
            {
                MessageBox.Show("Please enter a license ID in the filter input.");
                return;
            }

            string input = mtbLicenseFilterInput.Text.Trim();

            if (int.TryParse(input, out int id))
            {
                if (clsLicense.IsLicenseExist(id))
                {
                    if (!clsLicense.isLicenseActive(id))
                    {
                        MessageBox.Show("Local Driving License with this ID is not active.");
                        if (OnLicenseSearchFail != null)
                            // Raise the event without parameters
                            OnLicenseSearchFail();
                        return;
                    }
                    else
                    {
                        if (this.Mode == enLicenseMode.Detain)
                        {
                            if (clsLicense.IsLicenseDetained(id))
                            {
                                MessageBox.Show("This license is already detained.");
                                if (OnLicenseSearchFail != null)
                                    // Raise the event without parameters
                                    OnLicenseSearchFail();
                                return;
                            }

                        }
                        else if (this.Mode == enLicenseMode.Release)
                        {
                            if (!clsLicense.IsLicenseDetained(id))
                            {
                                MessageBox.Show("This license is not detained.");
                                if (OnLicenseSearchFail != null)
                                    // Raise the event without parameters
                                    OnLicenseSearchFail();
                                return;
                            }
                        }
                        {
                            if (OnLicenseSearchComplete != null)
                                // Raise the event with a parameter
                                OnLicenseSearchComplete(id);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Local Driving License with this ID does not exist.");
                    if (OnLicenseSearchFail != null)
                        // Raise the event without parameters
                        OnLicenseSearchFail();
                }
            }
        }
    }
}
