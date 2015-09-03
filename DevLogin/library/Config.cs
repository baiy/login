using System;
using System.Collections.Generic;
using System.Configuration;

namespace DevLogin.library
{
    class Config
    {
        public static string Get(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}
