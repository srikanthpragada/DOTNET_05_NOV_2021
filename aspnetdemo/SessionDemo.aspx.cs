using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetdemo
{
    public partial class SessionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Session Count = " + Application["count"]);
            Trace.Write("Value of cookie city : " + Request.Cookies["city"]);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            List<String> languages = (List<String>) Session["languages"];
            if (languages == null)
            {
                languages = new List<String>();
                languages.Add(txtName.Text);
             }
            else
            {
                languages.Add(txtName.Text);
            }

            Session["languages"] = languages;  // Session.Add("languages",languages);

            // Display list of languages 
            var langs = "<ul>";
            foreach(var lang in languages)
            {
                langs += "<li>" + lang + "</li>";
            }
            langs += "</ul>";

            lblLanguages.Text = langs;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Session.Clear();
            lblLanguages.Text = "";  
        }
    }
}