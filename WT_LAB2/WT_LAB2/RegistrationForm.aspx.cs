using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB2
{
    public partial class RegistrationForm : System.Web.UI.Page
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

            string text = "Name: " + TextBox1.Text.ToString() + " \r\n" +
                          "Mobile No.: " + TextBox2.Text.ToString() + "\r\n" +
                          "Email: " + TextBox3.Text.ToString() + " \r\n" +
                          "Address: " + TextBox4.Text.ToString() + " \r\n" +
                          "Country: " + DropDownList1.SelectedItem.Text.ToString() + " \r\n" +
                          "State: " + DropDownList2.SelectedItem.Text.ToString() + "\r\n" +
                          "City: " + DropDownList3.SelectedItem.Text.ToString() + "\r\n" +
                          "Certificates: " + GetSelectedCheckBoxListItems(CheckBoxList1) + "\r\n" +
                          "Gender: " + RadioButtonList1.SelectedItem.Text.ToString();


            text = text.Replace("\r\n", "<br />").Replace("\n", "<br />");


            Label1.Text = text;
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