using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int id = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.tbl_Contact.Find(id);
            TxtAdSoyad.Text = mesaj.fullName;
            TxtMail.Text = mesaj.mail;
            TxtKonu.Text = mesaj.topic;
            TxtMesaj.Text = mesaj.message;
        }
    }
}