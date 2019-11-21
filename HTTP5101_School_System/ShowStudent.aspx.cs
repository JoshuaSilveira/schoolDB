using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ShowStudent : System.Web.UI.Page
    {
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            bool valid = true;
            string studentid = Request.QueryString["studentid"];
            if (String.IsNullOrEmpty(studentid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {
                id = Int32.Parse(studentid);
                var db = new SCHOOLDB();
                Dictionary<String, String> student_record = db.FindStudent(id);

                
                List<Dictionary<String, String>> rs = db.List_Query("SELECT CLASSCODE,STARTDATE,FINISHDATE,CLASSNAME FROM `classes` inner join studentsxclasses on " +
                    "classes.CLASSID = studentsxclasses.CLASSID WHERE studentsxclasses.STUDENTID = "+id+"");

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

                if (student_record.Count > 0)
                {
                    student_title_fname.InnerHtml = student_record["STUDENTFNAME"] + " " + student_record["STUDENTLNAME"];
                    student_fname.InnerHtml = student_record["STUDENTFNAME"];
                    student_lname.InnerHtml = student_record["STUDENTLNAME"];
                    student_number.InnerHtml = student_record["STUDENTNUMBER"];
                    enrolment_date.InnerHtml = student_record["ENROLMENTDATE"];

                    
                    
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                student.InnerHtml = "There was an error finding that student.";
            }
        }

        protected void deleteStudent_Click(object sender, EventArgs e)
        {
            var db = new SCHOOLDB();
            db.Add_Query("DELETE FROM `students` WHERE `STUDENTID` = " + id + "");
            Server.Transfer("ListStudents.aspx");
        }
    }
}