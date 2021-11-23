using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetdemo
{
    public partial class PriceCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            var price = Double.Parse(txtPrice.Text);
            var qty = Double.Parse(txtQty.Text);

            var amount = price * qty;

            if (chkDiscount.Checked)
                amount *= .90;   // 10% discount 

            if (rbInstallments.Checked)
                amount *= 1.05;

            lblResult.Text = amount.ToString();

        }
    }
}