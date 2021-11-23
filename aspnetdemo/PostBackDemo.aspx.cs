﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetdemo
{
    public partial class PostBackDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                lblMsg.Text = "No. of sessions = " + ddlCourses.SelectedItem.Value;
            }
            else
                lblMsg.Text = "Direct";


        }
    }
}