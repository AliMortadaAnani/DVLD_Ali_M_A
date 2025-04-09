using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data;
using DVLD_DataTypes;



namespace DVLD_Business
{
    public class clsPeople
    {
        public static DataTable GetAllPeople()
        {
            /*DataTable dt = new DataTable();
            dt = clsPeopleData.GetAllPeople();
            dt.Columns.Remove("ThirdName");
            dt.Columns.Remove("NationalityCountryId");
            dt.Columns.Remove("ImagePath");
            dt.ConvertColumnType("Gender", typeof(String)); // StackOverFlow
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Gender"].ToString() == "0")
                {
                    dr["Gender"] = "Male";
                }
                else
                {
                    dr["Gender"] = "Female";
                }
            }
            return dt;*/
            return clsPeopleData.GetAllPeople();
        }

        public static int GetPeopleTotalRecords()
        {
            return clsPeopleData.GetPeopleTotalRecords();
        }

        public static DataTable GetPeopleByFirstName(string FirstName)
        {
            return clsPeopleData.GetAllPeopleByFirstName(FirstName);
        }
    }
}
