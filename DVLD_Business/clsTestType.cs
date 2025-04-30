using Azure.Core.Pipeline;
using DVLD_Data;
using DVLD_General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
   public class clsTestType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Fees { get; set; }
        public string Description { get; set; }
        
        private clsTestType(int testTypeID, string title, int fees, string description)
        {
            ID = testTypeID;
            Title = title;
            Fees = fees;
            Description = description;
        }

        private bool _UpdateTestType()
        {
            //call DataAccess Layer 
            return clsTestTypes.UpdateTestType(this.ID, this.Title, this.Fees, this.Description);
        }


        public bool Save()
        {
            return _UpdateTestType();
           
        }


        public static clsTestType GetByID(int ID)
        {
            string title = "";
            int fees = 0;
            string description = "";



           if(clsTestTypes.GetTestTypeInfoByID(ID, ref title, ref fees, ref description))
            {
                return new clsTestType(ID, title, fees, description);
            }
            else
                return null;
        }


        public static DataTable GetAllTestTypes()
        {
            return clsTestTypes.GetAllTestTypes();
        }

        public static int GetTestTypeCount()
        {
            return clsTestTypes.TotalTestTypesCount();
        }
    }
}
