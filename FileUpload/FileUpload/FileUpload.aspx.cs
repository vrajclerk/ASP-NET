using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUpload
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension = Path.GetExtension(FileUpload1.FileName);
                if (fileExtension.ToLower() != ".doc" && fileExtension.ToLower() != ".docx")
                {

                    Label1.Text = "Only files with .doc and .docx extension are allowed";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        Label1.Text = "File size must not exceed 2MB";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Images/" + FileUpload1.FileName));
                        Label1.Text = "File Uploaded Successfully";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                Label1.Text= "Please Select File";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
