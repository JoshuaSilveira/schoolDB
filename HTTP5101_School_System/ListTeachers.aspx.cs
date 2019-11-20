using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace HTTP5101_School_System
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            String searchQuery = "";
            teachers_result.InnerHtml = "";
            if (Page.IsPostBack)
            {
                searchQuery = search.Text.ToString();
            }

            string query = "select * from teachers";

            if (searchQuery != "")
            {
                query += " WHERE TEACHERFNAME like '%" + searchQuery + "%' ";
                query += " or TEACHERLNAME like '%" + searchQuery + "%' ";
               // query += " or EMPLOYEENUMBER like '%" + searchQuery + "%' ";
            }
            System.Diagnostics.Debug.WriteLine(query); 

            var db = new SCHOOLDB();
                List<Dictionary<String, String>> rs = db.List_Query(query);
                foreach (Dictionary<String, String> row in rs)
                {
                    teachers_result.InnerHtml += "<div class=\"listitem\">";

                    string teacherid = row["TEACHERID"];

                    string teacherfirstname = row["TEACHERFNAME"];
                    teachers_result.InnerHtml += "<div class=\"col5\"><a href=\"ShowTeacher.aspx?teacherid="+ teacherid + "\">" + teacherfirstname + "</a></div>";

                    string teacherlastname = row["TEACHERLNAME"];
                    teachers_result.InnerHtml += "<div class=\"col5\">" + teacherlastname + "</div>";

                    string employeenumber = row["EMPLOYEENUMBER"];
                    teachers_result.InnerHtml += "<div class=\"col5\">" + employeenumber + "</div>";

                    string hiredate = row["HIREDATE"];
                    teachers_result.InnerHtml += "<div class=\"col5\">" + hiredate + "</div>";

                    string salary = row["SALARY"];
                    teachers_result.InnerHtml += "<div class=\"col5last\">" + salary + "</div>";


                    teachers_result.InnerHtml += "</div>";
                }
            }
  
    }
}