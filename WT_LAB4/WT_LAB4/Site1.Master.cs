using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WT_LAB4
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public TextBox mstrtxt
        {
            get
            {
                return TextBox1;
            }
        }
        public Button mstrbtn
        {
            get
            {
                return Button1;
            }
        }
        public Label mstrlbl
        {
            get
            {
                return Label1;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }

    }
}