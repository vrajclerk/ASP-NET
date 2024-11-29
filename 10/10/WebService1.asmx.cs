using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _10
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable getStudentDetails(String ID)
        {
            DataTable students = new DataTable();
            students.Columns.Add("ID");
            students.Columns.Add("Name");
            students.Columns.Add("Age");
            students.Rows.Add(1, "John", 25);
            students.Rows.Add(2, "Smith", 30);
            students.Rows.Add(3, "David", 35);
            // Create a new DataTable to store the filtered result
            DataTable resultTable = students.Clone(); // Copy structure of 'students'

            // Filter the rows based on the provided ID
            DataRow[] resultRows = students.Select("ID = '" + ID + "'");
            foreach (DataRow row in resultRows)
            {
                resultTable.ImportRow(row);
            }

            return resultTable;
        }
    }
}
