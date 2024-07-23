using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB4
{
    public partial class Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sname = DropDownList1.SelectedItem.Text;

            if (sname == "India")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add(new ListItem("Select State", ""));
                DropDownList2.Items.Add("Gujarat");
                DropDownList2.Items.Add("Rajasthan");
                DropDownList2.Items.Add("Maharashtra");
            }
            else if (sname == "USA")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add(new ListItem("Select State", ""));
                DropDownList2.Items.Add("California");
                DropDownList2.Items.Add("Texas");
                DropDownList2.Items.Add("Georgia");
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = DropDownList2.SelectedItem.Text;

            if (state == "Gujarat")
            {
                DropDownList3.Items.Clear();
                //DropDownList3.Items.Add(new ListItem("Select City", ""));
                DropDownList3.Items.Add("Surat");
                DropDownList3.Items.Add("Ahmedabad");
                DropDownList3.Items.Add("Vadodara");
            }
            else if (state == "Rajasthan")
            {
                DropDownList3.Items.Clear();
                //DropDownList3.Items.Add(new ListItem("Select City", ""));
                DropDownList3.Items.Add("Jaipur");
                DropDownList3.Items.Add("Udaipur");
                DropDownList3.Items.Add("Ajmer");
            }
            else if (state == "Maharashtra")
            {
                DropDownList3.Items.Clear();
                //DropDownList3.Items.Add(new ListItem("Select City", ""));
                DropDownList3.Items.Add("Mumbai");
                DropDownList3.Items.Add("Pune");
                DropDownList3.Items.Add("Lonavala");
            }
            else if (state == "California")
            {
                DropDownList3.Items.Clear();
                //DropDownList3.Items.Add(new ListItem("Select City", ""));
                DropDownList3.Items.Add("Los Angeles");
                DropDownList3.Items.Add("San Francisco");
            }
            else if (state == "Texas")
            {
                DropDownList3.Items.Clear();
                //DropDownList3.Items.Add(new ListItem("Select City", ""));
                DropDownList3.Items.Add("Houston");
                DropDownList3.Items.Add("Dallas");
                DropDownList3.Items.Add("Austin");
            }
            else if (state == "Georgia")
            {
                DropDownList3.Items.Clear();
               // DropDownList3.Items.Add(new ListItem("Select City", ""));
                DropDownList3.Items.Add("Atlanta");
                DropDownList3.Items.Add("Savannah");
                DropDownList3.Items.Add("Athens");
            }
        }

        protected void CheckBoxList1_Validate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = CheckBoxList1.Items.Cast<ListItem>().Any(item => item.Selected);
        }

        protected void Password_CustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string password = args.Value;
            if (password.Length < 8 ||
                !Regex.IsMatch(password, "[A-Z]") ||
                !Regex.IsMatch(password, "[0-9]"))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //string text = "Name: " + TextBox1.Text.ToString() + " \r\n" +
            //          "Mobile No.: " + TextBox2.Text.ToString() + "\r\n" +
            //          "Email: " + TextBox3.Text.ToString() + " \r\n" +
            //          "Address: " + TextBox4.Text.ToString() + " \r\n" +
            //          "Country: " + DropDownList1.SelectedItem.Text.ToString() + " \r\n" +
            //          "State: " + DropDownList2.SelectedItem.Text.ToString() + "\r\n" +
            //          "City: " + DropDownList3.SelectedItem.Text.ToString() + "\r\n" +
            //          "Certificates: " + GetSelectedCheckBoxListItems(CheckBoxList1) + "\r\n" +
            //          "Gender: " + RadioButtonList1.SelectedItem.Text.ToString();


            //text = text.Replace("\r\n", "<br />").Replace("\n", "<br />");


            //Label1.Text = text;
            if (Page.IsValid)
            { Response.Write("<h1>" + "Reg Done " + "</h1>"); }
            else
            {
                Response.Write("<h1>" + "Fill up all the details " + "</h1>");
            }

        }


        private string GetSelectedCheckBoxListItems(CheckBoxList checkBoxList)
        {
            List<string> selectedItems = new List<string>();

            foreach (ListItem item in checkBoxList.Items)
            {
                if (item.Selected)
                {
                    selectedItems.Add(item.Text);
                }
            }

            return string.Join(", ", selectedItems);
        }
    }
}