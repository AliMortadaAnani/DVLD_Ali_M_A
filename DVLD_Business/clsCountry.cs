using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data;

namespace DVLD_Business
{
    public class clsCountry
    { 
      public int ID { get; set; }
      public string CountryName {  get; set; }

      private clsCountry(int ID , string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName; 
        }

        public static DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }

        public static clsCountry Find(int ID)
        {
            string CountryName = null ;

            if(clsCountriesData.GetCountryInfoByID(ID, ref CountryName))
            {
                return new clsCountry(ID, CountryName);
            }
            else
            {
                return null;
            }



        }

        public static clsCountry Find(string CountryName)
        {
            int ID = -1;

            if (clsCountriesData.GetCountryInfoByName(CountryName , ref ID))
            {
                return new clsCountry(ID, CountryName);
            }
            else
            {
                return null;
            }



        }



    }
}
