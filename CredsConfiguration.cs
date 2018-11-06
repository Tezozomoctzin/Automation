using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace selenium_try
{
    static class CredsConfiguration
    {
        public static string Login { get; } = ConfigurationManager.AppSettings["Login"];
        public static string Password { get; } = ConfigurationManager.AppSettings["Password"];
        public static string LoginUrl { get; } = ConfigurationManager.AppSettings["LoginUrl"];


    }
}
