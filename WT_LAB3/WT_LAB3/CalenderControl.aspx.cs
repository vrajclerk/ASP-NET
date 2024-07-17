using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB3
{
    public partial class CalenderControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (var Date in Calendar1.SelectedDates)
            {
                Response.Write(Date.ToString() + "\n");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime dateTime = dt.AddDays(15);
            DateTime selected = Calendar1.SelectedDate;

            if (selected <= dateTime && selected >= dt)
            {
                Response.Write("Valid Date");

            }
            else
            {
                Response.Write("Invalid Date");
            }
        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Red;
            }

            if (e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Aquamarine;
            }
            if (e.Day.Date.ToShortDateString() == "03-05-2024")
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
            }

            if (e.Day.Date.ToShortDateString() == "15-08-2024")
            {
                e.Day.IsSelectable = false;
                // e.Cell.Text = "Independence day";
                Label l = new Label();
                l.Text = "Independenceday";
                e.Cell.BackColor = System.Drawing.Color.Green;

            }
            if (e.Day.Date.ToShortDateString() == "15-08-2024")
            {
                e.Day.IsSelectable = false;
                e.Cell.Text = "Independence day";
                Label l = new Label();
                l.Text = "Independenceday";
                e.Cell.BackColor = System.Drawing.Color.Green;

            }
            if (e.Day.Date.ToShortDateString() == "19-08-2024")
            {
                e.Day.IsSelectable = false;
                e.Cell.Text = "Rakshabandhan";
                Label l = new Label();
                l.Text = "Rakshabandhan";
                e.Cell.BackColor = System.Drawing.Color.Green;

            }
            if (e.Day.Date.ToShortDateString() == "26-08-2024")
            {
                e.Day.IsSelectable = false;
                e.Cell.Text = "Janmashtami";
                Label l = new Label();
                l.Text = "Janmashtami";
                e.Cell.BackColor = System.Drawing.Color.Green;

            }
            if (e.Day.Date.ToShortDateString() == "02-09-2024")
            {
                e.Day.IsSelectable = false;
                e.Cell.Text = "Gandhi jayanti";
                Label l = new Label();
                l.Text = "Independenceday";
                e.Cell.BackColor = System.Drawing.Color.Green;

            }


        }
    }
}