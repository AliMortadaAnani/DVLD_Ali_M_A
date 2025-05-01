using DVLD_Data;
using DVLD_General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public byte PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        // Constructor
        public clsApplication()
        {
            ID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsApplication(int id, int applicantPersonID, DateTime applicationDate,
            int applicationTypeID, enApplicationStatus applicationStatus,
            DateTime lastStatusDate, byte paidFees, int createdByUserID)
        {
            ID = id;
            ApplicantPersonID = applicantPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        private bool _AddNewApplication()
        {
            this.ID =  clsApplicationsData.AddNewApplication(ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            return (this.ID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationsData.UpdateApplication(ID, ApplicantPersonID, ApplicationDate,
                ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();

            }
            return false;
        }

        public static clsApplication GetApplicationByID(int id)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            enApplicationStatus ApplicationStatus = enApplicationStatus.New;
            DateTime LastStatusDate = DateTime.Now;
            byte PaidFees = 0;
            int CreatedByUserID = -1;
            if (clsApplicationsData.GetApplicationByID(id, ref ApplicantPersonID,
                ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus,
                ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(id, ApplicantPersonID, ApplicationDate,
                    ApplicationTypeID, ApplicationStatus, LastStatusDate,
                    (byte)PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }



    }
}
