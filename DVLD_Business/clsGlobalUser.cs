using DVLD_General;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsGlobalUser
    {   
        public static clsUser CurrentUser;

        //public static string filePath = IniConfig.GetValue("Paths", "RememberMePath");
        //Write your local filepath in config.ini in DVLD_General

        static string relativePath = IniConfig.GetValue("Paths", "RememberMePath");
        static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);



        public static void SaveUserIdToFile(int ID)
        {
            if (File.Exists(filePath))
            {

                File.WriteAllText(filePath, ID.ToString());
                
            }
            else
            {
                Console.WriteLine("File not found.");
            }
           
        }

        public static int ReadUserIdFromFile()
        {
            if (File.Exists(filePath))
            {

                string readContent = File.ReadAllText(filePath);
                return Convert.ToInt32(readContent);
            }
            else
            {
                Console.WriteLine("File not found.");
                return -1; // or some other default value
            }

        }


        

        
    }
}
