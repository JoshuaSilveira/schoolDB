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
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true;
            string teacherid = Request.QueryString["teacherid"];
            if (String.IsNullOrEmpty(teacherid)) valid = false;
            //We will attempt to get the record we need
            if (valid)
            {
                id = Int32.Parse(teacherid);

                var db = new SCHOOLDB();
                Dictionary<String, String> teacher_record = db.findTeacher(Int32.Parse(teacherid));
                List<Dictionary<String, String>> rs = db.List_Query("SELECT CLASSCODE,STARTDATE,FINISHDATE,CLASSNAME FROM `classes` WHERE teacherid = " + Int32.Parse(teacherid) + "");

                foreach (Dictionary<String, String> row in rs)
                {
                    classes_result.InnerHtml += "<div class=\"listitem\">";

                    string classcode = row["CLASSCODE"];
                    classes_result.InnerHtml += "<div class=\"col4\">" + classcode + "</div>";

                    string startdate = row["STARTDATE"];
                    classes_result.InnerHtml += "<div class=\"col4\">" + startdate + "</div>";

                    string finishdate = row["FINISHDATE"];
                    classes_result.InnerHtml += "<div class=\"col4\">" + finishdate + "</div>";

                    string classname = row["CLASSNAME"];
                    classes_result.InnerHtml += "<div class=\"col4last\">" + classname + "</div>";

                    classes_result.InnerHtml += "</div>";

                }

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
                teacher.InnerHtml = "There was an error finding that student.";
            }


        }
        protected void deleteTeacher_Click(object sender, EventArgs e)
        {
            var db = new SCHOOLDB();
            db.Add_Query("DELETE FROM `teachers` WHERE `teacherid` = " + id + "");
            Server.Transfer("ListTeachers.aspx");
        }
    }
}