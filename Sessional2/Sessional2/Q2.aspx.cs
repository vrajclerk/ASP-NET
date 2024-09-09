using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessional2
{
    public partial class Q2 : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            disp();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using(EmployeeClassDataContext ecx = new EmployeeClassDataContext(cs))
            {
                Employee e1 = new Employee();
                e1.Emp_Id = Convert.ToInt32(TextBox1.Text);
                e1.Emp_name = Convert.ToString(TextBox2.Text);
                e1.Emp_Desg = Convert.ToString(TextBox3.Text);
                e1.Dept = Convert.ToString(TextBox4.Text);
                e1.Salary = Convert.ToInt32(TextBox5.Text);
                ecx.Employees.InsertOnSubmit(e1);
                ecx.SubmitChanges();
                disp();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (EmployeeClassDataContext ecx = new EmployeeClassDataContext(cs))
            {
                Employee e1 = ecx.Employees.SingleOrDefault(x => x.Emp_Id == Convert.ToInt32(TextBox1.Text));
                e1.Emp_name = Convert.ToString(TextBox2.Text);
                e1.Emp_Desg = Convert.ToString(TextBox3.Text);
                e1.Dept = Convert.ToString(TextBox4.Text);
                e1.Salary = Convert.ToInt32(TextBox5.Text);
                ecx.SubmitChanges();
                disp();
                
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (EmployeeClassDataContext ecx = new EmployeeClassDataContext(cs))
            {
                Employee e1 = ecx.Employees.SingleOrDefault(x => x.Emp_Id == Convert.ToInt16(TextBox1.Text));
                ecx.Employees.DeleteOnSubmit(e1);
                ecx.SubmitChanges();
                disp();

            }
        }
        public void disp()
        {
            using (EmployeeClassDataContext ecx = new EmployeeClassDataContext(cs))
            {
                var res = from a in ecx.Employees
                          select a;
               
                GridView1.DataSource = res;
                GridView1.DataBind();
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            disp();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            using (EmployeeClassDataContext ecx = new EmployeeClassDataContext(cs))
            {
                var res = (from e1 in ecx.Employees select e1.Salary).Average();
                TextBox6.Text = res.ToString();
            }
        }
    }
}