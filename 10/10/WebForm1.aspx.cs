﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFetch_Click(object sender, EventArgs e)
        {
            WebService1 ws = new WebService1();
            DataTable res = ws.getStudentDetails(txtStudentId.Text);
            gvStudentDetails.DataSource = res;
            gvStudentDetails.DataBind();
        }
    }
}