using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace adonetdemo
{
    public class Database
    {
        // static property
        public static string ConnectionString
        { 
            get
            {
                return WebConfigurationManager.ConnectionStrings["msdbConnectionString"].ConnectionString;
            }
        }
    }
}