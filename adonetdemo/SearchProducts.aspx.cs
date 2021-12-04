using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adonetdemo
{
    public partial class SearchProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from products where prodname like @name", con);
            da.SelectCommand.Parameters.AddWithValue("@name", "%" + txtName.Text + "%");

            DataSet ds = new DataSet();
            da.Fill(ds, "products");

            dlProducts.DataSource = ds.Tables["products"];
            dlProducts.DataBind();
        }
    }
}