using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntity
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        CvEntityEntities db = new CvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterYetenekler.DataSource = db.TblYetenekler.ToList();
            RepeaterYetenekler.DataBind();
        }
    }
}