using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntity
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        CvEntityEntities db = new CvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            var mesaj = db.TblIletisim.Find(id);

            TextBoxAdSoyad.Text = mesaj.AdSoyad;
            TextBoxMail.Text = mesaj.Mail;
            TextBoxKonu.Text = mesaj.Konu;
            TextBoxMesaj.Text = mesaj.Mesaj;
        }
    }
}