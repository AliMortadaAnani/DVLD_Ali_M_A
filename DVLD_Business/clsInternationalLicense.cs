using DVLD_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        // Constructor
        public clsInternationalLicense()
        {
            ID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            IsActive = false;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }
        private clsInternationalLicense(int id, int applicationID, int driverID, int issuedUsingLocalLicenseID,
            DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            ID = id;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        private bool _AddNewInternationalLicense()
        {
            this.ID = clsInternationalLicensesData.AddLicense(ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            return (this.ID != -1);
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                

            }
            return false;
        }


        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicensesData.GetAllInternationalLicenses();
        }

        public static bool IsInternationalLicenseExists(int LocalLicenseID)
        {
            return clsInternationalLicensesData.HasLicense(LocalLicenseID);
        }

        public  static int GetInternationalLicenseIdByLocalLicenseID(int LocalLicenseID)
        {
            return clsInternationalLicensesData.GetIntLicenseIDByLocalLicenseID(LocalLicenseID);
        }

        public static clsInternationalLicense GetLicense(int ID)
        {
            int applicationID = -1;
            int driverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            
            bool isActive = false;
          
            int createdByUserID = -1;

            if (clsInternationalLicensesData.GetLicenseByID(ID, ref applicationID, ref driverID,
                 ref IssuedUsingLocalLicenseID, ref issueDate, ref expirationDate, 
                 ref isActive,ref createdByUserID))
            {
                return new clsInternationalLicense(ID, applicationID, driverID, IssuedUsingLocalLicenseID,
                    issueDate, expirationDate, isActive, createdByUserID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetInternationalLicenseByID(int InternationalLicenseID)
        {
            return clsInternationalLicensesData.GetInternationalLicensesByInternationalLicensesID(InternationalLicenseID);
        }

        public static DataTable GetInternationalLicensesByLocalLicenseID(int LocalLicenseID)
        {
            return clsInternationalLicensesData.GetInternationalLicensesByInternationalLicensesID(LocalLicenseID);
        }

        public static DataTable GetInternationalLicensesByDriverID(int DriverID)
        {
            return clsInternationalLicensesData.GetInternationalLicensesByDriversID(DriverID);
        }

        public static DataTable GetInternationalLicensesBIsActive(bool IsActive)
        {
            return clsInternationalLicensesData.GetInternationalLicensesByIsActive(IsActive);
        }

    }
}
