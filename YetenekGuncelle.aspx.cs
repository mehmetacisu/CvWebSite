using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntity
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        CvEntityEntities db = new CvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            if (Page.IsPostBack ==false)
            {
                var yetenek = db.TblYetenekler.Find(id);
                TextBoxYetenek.Text = yetenek.Yetenek;
            }
        }

        protected void buttonKayet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            var yetenek = db.TblYetenekler.Find(id);
            yetenek.Yetenek = TextBoxYetenek.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}