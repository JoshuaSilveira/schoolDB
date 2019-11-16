using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string teacherfname = "";
            string teacherlname = "";
            string employeenumber = "";
            string hiredate = "";
            string salary = "";
            string teacherid = "";
            var db = new SCHOOLDB();
            if (Page.IsPostBack)
            {
                teacherfname = name.Text.ToString();
                teacherlname = lname.Text.ToString();
                employeenumber = teacher_employeenumber.Text.ToString();
                hiredate = teacher_hiredate.Text.ToString();
                salary = teacher_salary.Text.ToString();
                teacherid = teacher_id.Text.ToString();
                int id = Convert.ToInt32(teacherid);
                db.Add_Query("INSERT INTO `teachers`(`TEACHERID`,`TEACHERFNAME`, `TEACHERLNAME`, `EMPLOYEENUMBER`, `HIREDATE`, `SALARY`) " +
                "VALUES ("+id+",'"+teacherfname+ "','" + teacherlname + "','" + employeenumber + "','" + hiredate + "','" + salary + "')");
            }
            
            
            System.Diagnostics.Debug.WriteLine(teacherfname);
            
        }
    }
}