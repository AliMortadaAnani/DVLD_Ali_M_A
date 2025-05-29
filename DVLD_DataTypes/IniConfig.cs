using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_General
{
    public static class IniConfig
    {
        public static string GetValue(string section, string key, string filePath = "config.ini")
        {
            if (!File.Exists(filePath)) return null;

            string[] lines = File.ReadAllLines(filePath);
            string currentSection = "";
            foreach (string rawLine in lines)
            {
                string line = rawLine.Trim();
                if (line.StartsWith(";") || line == "") continue;

                if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    currentSection = line.Substring(1, line.Length - 2);
                    continue;
                }

                if (currentSection == section && line.Contains('='))
                {
                    string[] parts = line.Split('=', 2);
                    if (parts[0].Trim() == key)
                        return parts[1].Trim();
                }
            }

            return null;
        }
    }
}
