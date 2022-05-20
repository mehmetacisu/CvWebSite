using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntity
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        CvEntityEntities db = new CvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonKayet_Click(object sender, EventArgs e)
        {
            TblYetenekler yetenek = new TblYetenekler();
            yetenek.Yetenek = TextBoxYetenek.Text;
            db.TblYetenekler.Add(yetenek);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}