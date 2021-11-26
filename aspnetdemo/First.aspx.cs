using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetdemo
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Second.aspx");
        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            Server.Transfer("Second.aspx");
        }

        protected void btnExecute_Click(object sender, EventArgs e)
        {
            Server.Execute("Second.aspx");
        }
    }
}