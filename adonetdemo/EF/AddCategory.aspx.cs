using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adonetdemo.EF
{
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var ctx = new InventoryContext();
            var cat = new Category { Code = txtCode.Text, Description = txtDesc.Text };
            ctx.Categories.Add(cat);
            ctx.SaveChanges();
            Response.Redirect("ListCategories.aspx");

        }
    }
}