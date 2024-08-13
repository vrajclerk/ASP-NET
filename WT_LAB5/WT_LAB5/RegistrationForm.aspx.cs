using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace WT_LAB5
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sname = DropDownList1.SelectedItem.Text;

            if (sname == "India")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Gujrat");
                DropDownList2.Items.Add("Rajsthan");
                DropDownList2.Items.Add("Maharashtra");
            }
            else if (sname == "USA")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("California");
                DropDownList2.Items.Add("Texas");
                DropDownList2.Items.Add("Georgia");
            }


        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = DropDownList2.SelectedItem.Text;

            if (state == "Gujrat")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Surat");
                DropDownList3.Items.Add("Ahemdabad");
                DropDownList3.Items.Add("Vadodara");
            }
            else if (state == "Rajsthan")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Jaipur");
                DropDownList3.Items.Add("Udaipur");
                DropDownList3.Items.Add("Ajmer");
            }
            else if (state == "Maharashtra")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Mumbai");
                DropDownList3.Items.Add("Pune");
                DropDownList3.Items.Add("Lonavala");
            }
            else if (state == "California")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Los Angeles");
                DropDownList3.Items.Add("Las Vegas");
                DropDownList3.Items.Add("San Fransisco");
            }
            else if (state == "Texas")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Houston");
                DropDownList3.Items.Add("Dallas");
                DropDownList3.Items.Add("Austin");
            }
            else if (state == "Georgia")
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Atlanta");
                DropDownList3.Items.Add("Savannah");
                DropDownList3.Items.Add("Athens");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = "INSERT INTO Register (ID,Name, MobileNo, Email, Address, Country, State, City, Certificates, Gender) VALUES (" +
                "'" + TextBox1.Text + "', " +
                "'" + TextBox2.Text + "', " +
                "'" + TextBox3.Text + "', " +
                "'" + TextBox4.Text + "', " +
                "'" + DropDownList1.SelectedValue + "', " +
                "'" + DropDownList2.SelectedValue + "', " +
                "'" + DropDownList3.SelectedValue + "', " +
                "'" + string.Join(",", CheckBoxList1.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Text).ToArray()) + "', " +
                "'" + RadioButtonList1.SelectedValue + "')";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                conn.Open();
                int n = sqlCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    Response.Write("Insert error");
                }
                else
                {
                    display();
                }
            }
        }
        protected void display()
        {
            using (SqlConnection conn = new SqlConnection(cs)) {
                SqlCommand sqlCommand = conn.CreateCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = "Select * from Register";

                SqlDataReader reader;
                conn.Open();
                reader = sqlCommand.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
    }
}