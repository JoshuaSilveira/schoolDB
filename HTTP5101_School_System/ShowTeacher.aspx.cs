using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ShowTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true;
            string teacherid = Request.QueryString["teacherid"];
            if (String.IsNullOrEmpty(teacherid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {
                var db = new SCHOOLDB();
                Dictionary<String, String> teacher_record = db.findTeacher(Int32.Parse(teacherid));

                if (teacher_record.Count > 0)
                {
                    teacher_title_fname.InnerHtml = teacher_record["TEACHERFNAME"] + " " + teacher_record["TEACHERLNAME"];
                    teacher_fname.InnerHtml = teacher_record["TEACHERFNAME"];
                    teacher_lname.InnerHtml = teacher_record["TEACHERLNAME"];
                    employee_number.InnerHtml = teacher_record["EMPLOYEENUMBER"];
                    hire_date.InnerHtml = teacher_record["HIREDATE"];
                    teacher_salary.InnerHtml = teacher_record["SALARY"];
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
            }
        }
    }
}