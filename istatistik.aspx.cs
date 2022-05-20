using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntity
{
    public partial class istatistik : System.Web.UI.Page
    {
        CvEntityEntities db = new CvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TblYetenekler.Count().ToString();
            Label2.Text = db.TblIletisim.Count().ToString();
            Label3.Text = db.TblYetenekler.Average(x=>x.Derece).ToString();
            Label4.Text = db.TblYetenekler.Max(x=>x.Derece).ToString();
            int yetenek = (int)db.TblYetenekler.Max(x => x.Derece);
            Label5.Text = db.TblYetenekler.Where(x => x.Derece == yetenek).FirstOrDefault().Yetenek;
        }
    }
}