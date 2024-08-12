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

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime[] holidays =
            {
                new DateTime(DateTime.Now.Year,8,15),
                new DateTime(DateTime.Now.Year,7,17),
                new DateTime(DateTime.Now.Year,8,19),
                new DateTime(DateTime.Now.Year,10,31),
                new DateTime(DateTime.Now.Year,10,2)
            };

            DateTime birthday = new DateTime(DateTime.Now.Year, 10, 14);

            DateTime ses1start = new DateTime(DateTime.Now.Year, 7, 29);
            DateTime ses1end = ses1start.AddDays(2);

            DateTime ses2start = new DateTime(DateTime.Now.Year, 9, 2);
            DateTime ses2end = ses2start.AddDays(2);

            DateTime ses3start = new DateTime(DateTime.Now.Year, 10, 8);
            DateTime ses3end = ses3start.AddDays(2);

            DateTime extstart = new DateTime(DateTime.Now.Year, 11, 19);
            DateTime extend = extstart.AddDays(3);

            foreach (DateTime holiday in holidays)
            {
                if (e.Day.Date == holiday)
                {
                    e.Cell.BackColor = System.Drawing.Color.Green;
                    e.Cell.ToolTip = "Holiday";
                }
            }
            if (e.Day.Date == birthday)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
                e.Cell.ToolTip = "Birthday";
            }
            if (e.Day.Date >= ses1start && e.Day.Date <= ses1end)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ToolTip = "Sessional 1";
                e.Day.IsSelectable = false;
            }
            if (e.Day.Date >= ses2start && e.Day.Date <= ses2end)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ToolTip = "Sessional 2";
                e.Day.IsSelectable = false;
            }
            if (e.Day.Date >= ses3start && e.Day.Date <= ses3end)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ToolTip = "Sessional 3";
                e.Day.IsSelectable = false;
            }
            if (e.Day.Date >= extstart && e.Day.Date <= extend)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ToolTip = "External";
                e.Day.IsSelectable = false;
            }
            if (e.Day.IsWeekend)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ToolTip = "Weekend";
            }
            if (e.Day.IsOtherMonth)
            {
                e.Cell.BackColor = System.Drawing.Color.DeepSkyBlue;
                e.Cell.ToolTip = "Other Month";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        }
    }
}