using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CvEntityProject
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack==false)
            {
                var yetenek = db.tbl_Skills.Find(id);
                TextBox1.Text = yetenek.skills;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var yetenek = db.tbl_Skills.Find(id);
            yetenek.skills = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");

        }
    }
}