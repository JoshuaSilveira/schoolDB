using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP5101_School_System
{
    public partial class ShowClass : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true;
            string classid = Request.QueryString["classid"];
            if (String.IsNullOrEmpty(classid)) valid = false;

            if (valid)
            {
                id= Int32.Parse(classid);
                var db = new SCHOOLDB();
                Dictionary<String, String> class_record = db.FindClass(id);

                if (class_record.Count > 0)
                {
                    class_name.InnerHtml = class_record["CLASSNAME"];
                    class_code.InnerHtml = class_record["CLASSCODE"];
                    teacher_id.InnerHtml = class_record["TEACHERID"];
                    start_date.InnerHtml = class_record["STARTDATE"];
                    finish_date.InnerHtml = class_record["FINISHDATE"];



                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                course.InnerHtml = "There was an error finding that class.";
            }
        }

        protected void deleteClass_Click(object sender, EventArgs e)
        {
            var db = new SCHOOLDB();
            db.Add_Query("DELETE FROM `classes` WHERE `CLASSID` = " + id + "");
            Server.Transfer("ListClasses.aspx");
        }
    }
    }
