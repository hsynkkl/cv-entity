using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class Istatistik : System.Web.UI.Page
    {       
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.tbl_Skills.Count().ToString();
            Label2.Text = db.tbl_Contact.Count().ToString(); 
            Label3.Text = db.tbl_Skills.Average(x=>x.rate).ToString();
            Label4.Text = db.tbl_Skills.Max(x=>x.rate).ToString();
        }
    }
}