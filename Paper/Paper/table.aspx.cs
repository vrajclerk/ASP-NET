using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paper
{
    public partial class table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            int num_rows=Convert.ToInt16(DropDownList1.SelectedItem.Text);
            int num_cols=Convert.ToInt16(DropDownList2.SelectedItem.Text);
            string controlType = RadioButtonList1.SelectedValue.ToString();

            for(int i = 0; i < num_rows; i++) {
                TableRow row = new TableRow();

                for (int j = 0; j < num_cols; j++)
                {
                    TableCell cell = new TableCell();
                    switch (controlType)
                    {
                        case "TextBox":
                            TextBox textBox = new TextBox();
                            cell.Controls.Add(textBox);
                            break;

                        case "hyperlink":
                            HyperLink hyperLink = new HyperLink();
                            hyperLink.Text = "Hyperlink";
                            hyperLink.NavigateUrl = "Calender.aspx";
                            cell.Controls.Add(hyperLink);
                            break;

                        case "linkButton":
                            LinkButton linkButton = new LinkButton();
                            linkButton.Text = "Link Button";
                            cell.Controls.Add(linkButton);
                            break;
                    }
                }
     

        }
    }
}