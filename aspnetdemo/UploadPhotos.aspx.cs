using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetdemo
{
    public partial class UploadPhotos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string filename;
            if (FileUpload1.HasFile)  // file is uploaded 
            {
                //convert virtual path to physical path
                filename = Request.MapPath("photos/" + FileUpload1.FileName);
                FileUpload1.SaveAs(filename); // save file in the server
                lblMsg.Text = "File Uploaded Successfully : " + filename;
            }
            else
                lblMsg.Text = "Please select a file to upload!";
        }
    }
}