using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntity
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        CvEntityEntities db = new CvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            var yetenek = db.TblYetenekler.Find(id);
            db.TblYetenekler.Remove(yetenek);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}