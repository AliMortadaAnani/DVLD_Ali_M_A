using DVLD_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLicenseClass
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public byte ClassFees { get; set; }


        private clsLicenseClass(int licenseClassID, string className, string classDescription,
            int minimumAllowedAge, int defaultValidityLength, byte classFees)
        {
            ID = licenseClassID;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            ClassFees = classFees;
        }
        

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesData.GetAllLicenseClasses();
        }

        public static clsLicenseClass Find(int ID)
        {
            string className = "";
            string classDescription = "";
            int minimumAllowedAge = -1;
            int defaultValidityLength = -1;
            byte classFees = 0;
            if (clsLicenseClassesData.GetLicenseClassInfoByID(ID, ref className,
                ref classDescription, ref minimumAllowedAge,
                ref defaultValidityLength, ref classFees))
            {
                return new clsLicenseClass(ID, className, classDescription,
                    minimumAllowedAge, defaultValidityLength, classFees);
            }
            else
            {
                return null;
            }
        }

        public static clsLicenseClass Find(string className)
        {
            int ID = -1;
            string classDescription = "";
            int minimumAllowedAge = -1;
            int defaultValidityLength = -1;
            byte classFees = 0;
            if (clsLicenseClassesData.GetLicenseClassInfoByClassName(className, ref ID,
                ref classDescription, ref minimumAllowedAge,
                ref defaultValidityLength, ref classFees))
            {
                return new clsLicenseClass(ID, className, classDescription,
                    minimumAllowedAge, defaultValidityLength, classFees);
            }
            else
            {
                return null;
            }
        }

    }
}
