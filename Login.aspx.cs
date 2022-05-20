using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntity
{
    public partial class Login : System.Web.UI.Page
    {
        CvEntityEntities db = new CvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GirisYap_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TblAdmin where x.KullaniciAdi == KullaniciAdiniz.Text && x.Sifre == Sifre.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("iletisim.aspx");
            }
            else
            {
                Response.Write("Hatalı kullanıcı adı yada şifre !");
            }
        }
    }
}