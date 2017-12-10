using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ONEperson : System.Web.UI.Page
    {

        MOVIESEntities3 db = new MOVIESEntities3();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ss = (string)Session["person"];
            int hh = Convert.ToInt32(Session["personid"]);
            name.Text = ss;
            var query = from b in db.people where b.PID == hh select b;
            person per = query.Single();
            birth.Text = per.birth;
            rate.Text = per.prate.ToString();
            var quer = from g in db.people where g.Name == ss select new { g.job };
            GridView1.DataSource = quer.ToList();
            GridView1.DataBind();


            var img = from k in db.personps where k.personid == hh select k;
            personp imgs = img.Single();
            byte[] bebo = imgs.persp;
            string ptr = Convert.ToBase64String(bebo);
            Image1.ImageUrl = "data:image/png;base64," + ptr;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "work as";
            }
        }

        protected void urate_Click(object sender, EventArgs e)
        {
            string ss = (string)(Session["personid"]);
            int iD = Convert.ToInt32(ss);
            var query = from p in db.people where p.PID == iD select p;
            person fefo = query.Single();
            double crate = fefo.prate;
            int cnofrate = fefo.pnofrate;

            string state = (string)Session["status"];
            if (state == "loggedin")
            {
                double userrat = Convert.ToDouble(userrate.Text.ToString());

                double nrate = (cnofrate * crate + userrat) / (cnofrate + 1);
                cnofrate++;

                var person = db.people.Find(iD);
                person.prate = nrate;
                person.pnofrate = cnofrate;
                db.SaveChanges();

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('you must be logged in to submit your rate');", true);
            }
        }
    }
}