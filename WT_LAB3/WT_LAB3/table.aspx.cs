using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB3
{
    public partial class table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int nor = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            int noc = Convert.ToInt32(DropDownList2.SelectedValue.ToString());
            Table table = new Table();
            for (int i = 0; i < nor; i++)
            {

                TableRow row = new TableRow();

                for (int j = 0; j < noc; j++)

                {
                    TableCell cell = new TableCell();
                    if (i == 0)
                    {
                        LinkButton linkButton = new LinkButton();
                        linkButton.Text = "LinkButton";
                        cell.Controls.Add(linkButton);
                    }
                    else if (i == 1)
                    {
                        ImageButton imageButton = new ImageButton();
                        imageButton.AlternateText = "Image Button";
                        cell.Controls.Add(imageButton);
                    }
                    else if (i == 2)
                    {
                        HyperLink hyperLink = new HyperLink();
                        hyperLink.Text = "Hyper Link";
                        hyperLink.NavigateUrl = "#";
                        cell.Controls.Add(hyperLink);

                    }

                    row.Cells.Add(cell);

                }
                table.Rows.Add(row);

            }

            PlaceHolder1.Controls.Add(table);
        }

    }
}