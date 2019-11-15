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
            var db = new SCHOOLDB();

            //db.Add_Query("INSERT INTO `teachers`(`TEACHERID`,`TEACHERFNAME`, `TEACHERLNAME`, `EMPLOYEENUMBER`, `HIREDATE`, `SALARY`) VALUES (11,'Joshua','lname','4','2014-01-01','44')");
        }
    }
}