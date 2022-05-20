using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntity
{
    public partial class Iletisim : System.Web.UI.Page
    {
        CvEntityEntities db = new CvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var mesajlar = db.TblIletisim.ToList();
            RepeaterMesajlar.DataSource = mesajlar;
            RepeaterMesajlar.DataBind();
        }
    }
}