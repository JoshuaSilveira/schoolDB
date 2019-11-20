using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string studentfname = "";
            string studentlname = "";
            string studentnumber = "";
            string enrolldate = "";

            var db = new SCHOOLDB();
            if (Page.IsPostBack)
            {
                studentfname = name.Text.ToString();
                studentlname = lname.Text.ToString();
                studentnumber = student_number.Text.ToString();
                enrolldate = studentenrolldate.Text.ToString();
                db.Add_Query("INSERT INTO `students`(`STUDENTFNAME`, `STUDENTLNAME`, `STUDENTNUMBER`, `ENROLMENTDATE`) VALUES " +
                    "('" + studentfname + "','" + studentlname + "','" + studentnumber + "','" + enrolldate + "')");
            }
        }
    }
}