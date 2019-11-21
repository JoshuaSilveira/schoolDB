using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//make sure your final project has these
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace HTTP5101_School_System
{
    public partial class ListStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
                An alternate way to fetch data without the SCHOOLDB.cs class
                https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html
            */
            String searchQuery = "";
            students_result.InnerHtml = "";
            if (Page.IsPostBack)
            {
                searchQuery= search.Text.ToString();
            }

            string query = "select * from students";

            if (searchQuery != "")
            {
                query += " WHERE STUDENTFNAME like '%" + searchQuery + "%' ";
                query += " or STUDENTLNAME like '%" + searchQuery + "%' ";
                query += " or STUDENTNUMBER like '%" + searchQuery + "%' ";
            }
            System.Diagnostics.Debug.WriteLine(query);
            var db = new SCHOOLDB();
            //students_result.InnerHtml = "<div class=\"listitem\"></div>";
            //when information is pulled from database to chnage markup is called rendering loop
    
            List<Dictionary<String,String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                students_result.InnerHtml += "<div class=\"listitem\">";

                string studentid = row["STUDENTID"];

                string studentfirstname = row["STUDENTFNAME"];
                students_result.InnerHtml += "<div class=\"col4\"><a href=\"ShowStudent.aspx?studentid=" + studentid + "\">" + studentfirstname + "</a></div>";
               
                string studentlastname = row["STUDENTLNAME"];
                students_result.InnerHtml += "<div class=\"col4\">" + studentlastname + "</div>";

                string studentnumber = row["STUDENTNUMBER"];
                students_result.InnerHtml += "<div class=\"col4\">" + studentnumber + "</div>";

                string enrolmentdate = row["ENROLMENTDATE"];
                students_result.InnerHtml += "<div class=\"col4last\">" + enrolmentdate + "</div>";

                students_result.InnerHtml += "</div>";
            }
                

            
            
             
        }
    }
}