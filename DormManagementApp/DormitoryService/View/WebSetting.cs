using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DormManagementApp
{
    public class WebSetting
    {
        private static string ApiUrl { get { return ConfigurationManager.AppSettings["ApiUrl"]; } }

        public static string GetUrl(string action)
        {
            return string.Format("{0}/{1}", ApiUrl, action);
        }
    }
}
