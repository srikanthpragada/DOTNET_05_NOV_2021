using System.Web.Configuration;

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
    }
}
