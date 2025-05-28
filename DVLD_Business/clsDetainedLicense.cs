using DVLD_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDetainedLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }

        public clsDetainedLicense()
        {
            ID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = DateTime.MinValue; // Or another default
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;
            Mode = enMode.AddNew;
        }

        private clsDetainedLicense(int id, int licenseID, DateTime detainDate, decimal fineFees,
            int createdByUserID, bool isReleased, DateTime releaseDate,
            int releasedByUserID, int releaseApplicationID)
        {
            ID = id;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
            Mode = enMode.Update;
        }

        public static clsDetainedLicense GetDetention(int ID)
        {
            int licenseID = -1;
            DateTime detainDate = DateTime.Now;
            decimal fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MinValue;
            int releasedByUserID = -1;
            int releaseApplicationID = -1;

            if (clsDetainedLicensesData.GetLicenseByID(ID, ref licenseID, ref detainDate,
                 ref fineFees, ref createdByUserID, ref isReleased, ref releaseDate,
                 ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainedLicense(ID, licenseID, detainDate, fineFees,
                    createdByUserID, isReleased, releaseDate,
                    releasedByUserID, releaseApplicationID);
            }
            else
            {
                return null;
            }
        }
        public static clsDetainedLicense GetDetainedLicenseByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime detainDate = DateTime.Now;
            decimal fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releaseDate = DateTime.MinValue;
            int releasedByUserID = -1;
            int releaseApplicationID = -1;

            if (clsDetainedLicensesData.GetDetainedLicenseByLicenseID(LicenseID, ref DetainID, ref detainDate,
                 ref fineFees, ref createdByUserID, ref isReleased, ref releaseDate,
                 ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainedLicense(DetainID,LicenseID, detainDate, fineFees,
                    createdByUserID, isReleased, releaseDate,
                    releasedByUserID, releaseApplicationID);
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewDetention()
        {
            this.ID = clsDetainedLicensesData.AddLicense(LicenseID, DetainDate,
                FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                ReleasedByUserID, ReleaseApplicationID);
            return (this.ID != -1);
        }
        private bool _UpdateDetention()
        {
            return clsDetainedLicensesData.UpdateLicense(
            this.ID,
            this.LicenseID,
            this.DetainDate,
            this.FineFees,
            this.CreatedByUserID,
            this.IsReleased,
            this.ReleaseDate,
            this.ReleasedByUserID,
            this.ReleaseApplicationID
);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetention())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateDetention();
            }
            return false;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicensesData.GetAllDetainedLicenses();
        }

        public static bool ReleaseLicense(int LicenseID)
        {
            return clsDetainedLicensesData.ReleaseDetainLicense(LicenseID, true);
        }
        public static bool DetainLicense(int LicenseID)
        {
            return clsDetainedLicensesData.ReleaseDetainLicense(LicenseID, false);
        }

        public static DataTable GetAllDetainedLicensesByID(int DetainId)
        {
            return clsDetainedLicensesData.GetAllDetainedLicensesById(DetainId);

        }
        public static DataTable GetAllDetainedLicensesByLicenseID(int LicenseID)
        {
            return clsDetainedLicensesData.GetAllDetainedLicensesByLicenseId(LicenseID);

        }
        public static DataTable GetAllDetainedLicensesByNationalNumber(string NationalNumber)
        {
            return clsDetainedLicensesData.GetAllDetainedLicensesByNatNB(NationalNumber);

        }
        public static DataTable GetAllDetainedLicensesByIsReleased(bool IsReleased)
        {
            return clsDetainedLicensesData.GetAllDetainedLicensesByIsReleased(IsReleased);

        }
    }
}
