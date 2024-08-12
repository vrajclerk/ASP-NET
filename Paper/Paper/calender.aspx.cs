using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paper
{
    public partial class calender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // iterates through each date
            foreach (var Date in Calendar1.SelectedDates)
            {
                // converts the date to a string and
                Response.Write(Date.ToString() + "\n");
            }
        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime eventStart = new DateTime(DateTime.Now.Year, 08, 21);
            DateTime eventEnd = eventStart.AddDays(4);
            

            if(e.Day.Date>=eventStart.Date && e.Day.Date <= eventEnd)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor= System.Drawing.Color.Yellow;
            }
            if (e.Day.Date.DayOfWeek == DayOfWeek.Monday)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Red;
            }
            //if (e.Day.IsWeekend)
            //{
            //    e.Day.IsSelectable = false;
            //    e.Cell.BackColor = System.Drawing.Color.Red;
            //    e.Cell.Font.Bold = true;
            //}

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
                
                e.Cell.ToolTip = "Independence Day";
                e.Cell.BackColor = System.Drawing.Color.Green;

            }
          
            if (e.Day.Date.ToShortDateString() == "19-08-2024")
            {
                e.Day.IsSelectable = false;
                
                e.Cell.ToolTip = "Rakshabandhan";
                e.Cell.BackColor = System.Drawing.Color.Green;

            }
            

        }
    }
}