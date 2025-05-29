

using DVLD_General;

namespace DVLD_Data
{
   static class clsDataAccessSettings
    {
        public static string ConnectionString = IniConfig.GetValue("Paths", "ConnectionString");
    }
}
