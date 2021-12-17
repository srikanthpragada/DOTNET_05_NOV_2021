using System.Collections.Generic;
using System.Web.Configuration;
using System.Web.Mvc;

namespace books.Models
{
    public class DatabaseUtil
    {
        public static string ConnectionString
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["msdbConnectionString"].ConnectionString;
            }
        }

        public static List<SelectListItem> Ratings
        {
            get
            {
                var items = new List<SelectListItem>();
                for (int i = 1; i <= 5; i++)
                    items.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString()});

                return items;
            }
        }
    }
}
