using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.mstrbtn.Click += Mstrrbtn_Click;

        }
        private void Mstrrbtn_Click(object sender, EventArgs e)
        {
            Master.mstrlbl.Text = TextBox1.Text;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)Master.FindControl(“TextBox1”);
            Label1.Text = tb.text;
            //	Label1.Text = ( (TextBox) Master.FindControl(“TextBox1”)).Text;
            //	Label1.Text =  (Master.FindControl(“TextBox1”) as TextBox).Text;

        

    }
}