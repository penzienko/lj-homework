using System;
using System.Configuration;

namespace lj_framework.Config
{
    public static class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            Settings.AUT = ConfigurationManager.AppSettings["AUT"];
            Settings.ImpWait = Int32.Parse(ConfigurationManager.AppSettings["ImpWait"]);
        }
    }
}
