using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetdemo
{
    public partial class TakeCity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("city", txtCity.Text);
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);
            lblMsg.Text = "City Saved!";
            
        }
    }
}