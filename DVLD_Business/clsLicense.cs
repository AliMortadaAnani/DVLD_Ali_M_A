using DVLD_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public int ApplicationID { get; set; }

        public int DriverID { get; set; }
        public int LicenseClass { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Notes { get; set; }

        public decimal PaidFees { get; set; }

        public bool IsActive { get; set; }

        public byte IssueReason { get; set; }

        public int CreatedByUserID { get; set; }

        public clsLicense()
        {
            ID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now.AddYears(10);
            Notes = "";
            PaidFees = 0;
            IsActive = false;
            IssueReason = 0;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsLicense(int id, int applicationID, int driverID, int licenseClass,
            DateTime issueDate, DateTime expirationDate, string notes,
            decimal paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            ID = id;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        public static clsLicense GetLicense(int ID)
        {
            int applicationID = -1;
            int driverID = -1;
            int licenseClass = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now.AddYears(10);
            string notes = "";
            decimal paidFees = 0;
            bool isActive = false;
            byte issueReason = 0;
            int createdByUserID = -1;

            if (clsLicensesData.GetLicenseByID(ID, ref applicationID, ref driverID,
                 ref licenseClass, ref issueDate, ref expirationDate, ref notes,
                 ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicense(ID, applicationID, driverID, licenseClass,
                    issueDate, expirationDate, notes, paidFees, isActive,
                    issueReason, createdByUserID);
            }
            else
            {
                return null;
            }
        }
        public static clsLicense GetLicenseByAppID(int ID)
        {
            int LicenseID = -1;
            int driverID = -1;
            int licenseClass = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now.AddYears(10);
            string notes = "";
            decimal paidFees = 0;
            bool isActive = false;
            byte issueReason = 0;
            int createdByUserID = -1;

            if (clsLicensesData.GetLicenseByAppID(ID, ref LicenseID, ref driverID,
                 ref licenseClass, ref issueDate, ref expirationDate, ref notes,
                 ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicense(LicenseID, ID, driverID, licenseClass,
                    issueDate, expirationDate, notes, paidFees, isActive,
                    issueReason, createdByUserID);
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewLicense()
        {
            this.ID = clsLicensesData.AddLicense(ApplicationID, DriverID, LicenseClass,
                IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            return (this.ID != -1);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return true;
                    break;
            }
            return false;
        }

        public static DataTable GetAllLicensesByPersonID(int PersonID)
        {
            return clsLicensesData.GetAllLicensesPerPersonID(PersonID);
        }
        public static DataTable GetAllInternationalLicensesByPersonID(int PersonID)
        {
            return clsLicensesData.GetAllInternationalLicensesPerPersonID(PersonID);
        }
        public static bool DeleteLicense(int ID)
        {
            if (clsLicensesData.CheckLicenseIntegrity(ID))
            {
                return false;
            }
            else
            {
                return clsLicensesData.DeleteLicense(ID);

            }
        }

        public static bool CheckPersonHasLicenseClass(int PersonID, int LicenseClassID)
        {
            return clsLicensesData.PersonHasLicense(PersonID, LicenseClassID);
        }
        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsLicensesData.IsLicenseDetained(LicenseID);
        }

        public static bool IsOrdinaryLicenseExist(int LicenseID)
        {
            return clsLicensesData.IsOrdinaryLicenseExist(LicenseID);
        }
        public static bool IsLicenseExist(int LicenseID)
        {
            return clsLicensesData.IsLicenseExist(LicenseID);
        }

        public static bool DeactivateLicense(int LicenseID)
        {

            {
                return clsLicensesData.IsactiveLicense(LicenseID, false);
            }
        }
        public static bool ActivateLicense(int LicenseID)
        {

            {
                return clsLicensesData.IsactiveLicense(LicenseID, true);
            }
        }
        public static bool isLicenseActive(int LicenseID)
        {
            return clsLicensesData.IsLicenseActive(LicenseID);
        }
    }
}
