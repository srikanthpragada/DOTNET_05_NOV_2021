using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetdemo
{
    public partial class ShowMovies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie city = Request.Cookies["city"];
            if (city == null)  // cookie not found 
                Response.Redirect("TakeCity.aspx");
            else
                lblMovies.Text = $"Movies in city - {city.Value}";


        }
    }
}