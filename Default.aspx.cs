using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntity
{
    public partial class Default : System.Web.UI.Page
    {
        CvEntityEntities db = new CvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterBilgiler.DataSource = db.TblHakkimda.ToList();
            RepeaterBilgiler.DataBind();
            RepeaterEgitim.DataSource = db.TblHakkimda.ToList();
            RepeaterEgitim.DataBind();
            RepeaterDeneyimlerim.DataSource = db.TblHakkimda.ToList();
            RepeaterDeneyimlerim.DataBind();
            RepeaterYetenek.DataSource = db.TblYetenekler.ToList();
            RepeaterYetenek.DataBind();
        }

        protected void ButtonGonder_Click(object sender, EventArgs e)
        {
            TblIletisim mesaj = new TblIletisim();
            mesaj.AdSoyad = TextBoxAd.Text;
            mesaj.Konu = TextBoxKonu.Text;
            mesaj.Mail = TextBoxMail.Text;
            mesaj.Mesaj = TextBoxMesaj.Text;
            db.TblIletisim.Add(mesaj);
            db.SaveChanges();

        }
    }
}