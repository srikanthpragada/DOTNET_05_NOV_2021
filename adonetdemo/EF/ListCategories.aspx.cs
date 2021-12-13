using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adonetdemo.EF
{
    public partial class ListCategories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ctx = new InventoryContext();
            gvCategories.DataSource = ctx.Categories.ToList();
            gvCategories.DataBind();
        }
    }
}