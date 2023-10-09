using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class Default : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.tbl_AboutMe.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.tbl_AboutMe.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.tbl_AboutMe.ToList();
            Repeater3.DataBind(); 
            Repeater4.DataSource = db.tbl_Skills.ToList();
            Repeater4.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_Contact t = new tbl_Contact();
            t.fullName = TextBox1.Text;
            t.mail = TextBox2.Text;
            t.topic= TextBox4.Text;
            t.message= TextBox3.Text;
            db.tbl_Contact.Add(t);
            db.SaveChanges();

        }
    }
}