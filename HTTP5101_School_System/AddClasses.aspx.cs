using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string classid = "";
            string classcode = "";
            string teacherid = "";
            string startdate = "";
            string finishdate = "";
            string classname = "";

            var db = new SCHOOLDB();
            if (Page.IsPostBack)
            {
                classid = class_id.Text.ToString();
                classcode = class_code.Text.ToString();
                teacherid = teacher_id.Text.ToString();
                startdate = start_date.Text.ToString();
                finishdate = finish_date.Text.ToString();
                classname = class_name.Text.ToString();

                int cid = Convert.ToInt32(classid);
                int tid = Convert.ToInt32(teacherid);
                db.Add_Query("INSERT INTO `classes`(`CLASSID`, `CLASSCODE`, `TEACHERID`, `STARTDATE`, `FINISHDATE`, `CLASSNAME`) VALUES" +
                    " ('"+cid+"','"+classcode+"','"+tid+"','"+startdate+"','"+finishdate+"','"+classname+"')");
            }
        }
    }
}