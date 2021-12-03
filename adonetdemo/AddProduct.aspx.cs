using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adonetdemo
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Database.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("insert into products values(@name,@price,@qoh,@remarks,@catcode)", con);

            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@qoh", txtQoh.Text);
            cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
            cmd.Parameters.AddWithValue("@catcode", ddlCatCode.SelectedValue);
            try
            {
                cmd.ExecuteNonQuery();  // DML 
                lblMsg.Text = "Added product successfully!";
            }
            catch(Exception ex)
            {
                lblMsg.Text = "Sorry! Could not add product due to error!";
                Trace.Write("Error :" + ex.Message);
            }
         
            con.Close();

           
        }
    }
}