using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_service
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        private object lblMessage;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetDetails_Click(object sender, EventArgs e)
        {
            //lblMessage.Text = string.Empty;

            // Try to parse the input as an integer (student_id)
            int studentId;
            if (int.TryParse(txtStudentID.Text, out studentId))
            {
                // Create an instance of the web service client


                StudentService.StudentServiceSoapClient client = new StudentService.StudentServiceSoapClient();

                try
                {
                    // Call the GetStudentDetails method from the web service
                    DataSet ds = client.GetStudentDetails(studentId);

                    // Check if the dataset has any rows
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        // Bind the data to the GridView control
                        gvStudentDetails.DataSource = ds;
                        gvStudentDetails.DataBind();
                    }
                    else
                    {
                        // If no data is returned, clear the GridView and display a message
                        gvStudentDetails.DataSource = null;
                        gvStudentDetails.DataBind();
                        //lblMessage.Text = "No student found with the given ID.";
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that might occur during the web service call
                    //lblMessage.Text = "Error: Could not retrieve student details. Please try again later. <br />"
                                 //     + "Technical details: " + ex.Message;
                }
            }
            else
            {
                // Handle invalid student ID input
                //lblMessage.Text = "Please enter a valid numeric student ID.";
            }
        }
    }
}