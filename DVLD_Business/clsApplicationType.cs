using DVLD_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Fees { get; set; }


        private clsApplicationType(int applicationTypeID, string title, int fees)
        {
            ID = applicationTypeID;
            Title = title;
            Fees = fees;
        }

        private bool _UpdateApplicationType()
        {
            //call DataAccess Layer 
            return clsApplicationTypes.UpdateApplicationType(this.ID, this.Title, this.Fees);
        }

        public bool Save()
        {
            return _UpdateApplicationType();

        }

        public static clsApplicationType GetByID(int ID)
        {
            string title = "";
            int fees = 0;
            if (clsApplicationTypes.GetApplicationTypeInfoByID(ID, ref title, ref fees))
            {
                return new clsApplicationType(ID, title, fees);
            }
            else
                return null;

        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypes.GetAllApplicationTypes();
        }
        public static int GetApplicationTypeCount()
        {
            return clsApplicationTypes.TotalApplicationTypesCount();
        }

    }
}
