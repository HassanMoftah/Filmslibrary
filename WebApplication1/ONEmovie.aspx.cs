using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;


namespace WebApplication1
{
    public partial class ONEmovie : System.Web.UI.Page
    {

        MOVIESEntities3 db = new MOVIESEntities3();
        protected void Page_Load(object sender, EventArgs e)
        {

            string ss = (string)(Session["movieid"]);
            int iD = Convert.ToInt32(ss);
            var query = from p in db.films where p.ID == iD select p;
            film fef = query.Single();
            int x = fef.DIRid;
            int y = fef.Authorid;
            int z = fef.ID;
            rate.Text = fef.rate.ToString();
            moviename.Text = fef.Title.ToString();
            plot.Text = fef.plot.ToString();

            var q = from c in db.people where c.PID == x select c;
            person F = q.Single();
            dir.Text = F.Name.ToString();
            var b = from g in db.people where g.PID == y select g;
            person V = b.Single();
            auth.Text = V.Name.ToString();
            var img = from h in db.movieps where h.filmid == z select h;
            moviep bebo = img.Single();
            byte[] imgs = bebo.filmp; 
            string ptr = Convert.ToBase64String(imgs);
            Image1.ImageUrl = "data:image;base64," + ptr;
            GridView1.DataSource = db.getactors(z);
            GridView1.DataBind();

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Cast";
            }
        }

        protected void urate_Click(object sender, EventArgs e)
        {
            string ss = (string)(Session["movieid"]);
            int iD = Convert.ToInt32(ss);
            var query = from p in db.films where p.ID == iD select p;
            film fefo = query.Single();
            double crate = fefo.rate;
            int cnofrate = fefo.Nofrates;
            
            string state = (string)Session["status"];
            if(state=="loggedin")
            {
                double userrat = Convert.ToDouble(userrate.Text.ToString());
                if (userrat >= 0 && userrat <= 10)
                {
                    double nrate = (cnofrate * crate + userrat) / (cnofrate + 1);
                    cnofrate++;

                    var films = db.films.Find(iD);
                    films.rate = nrate;
                    films.Nofrates = cnofrate;
                    db.SaveChanges();
                    Response.Redirect("ONEmovie.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('must be number between 0 and 10');", true);
                }

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('you must be logged in to submit your rate');", true);
            }
        }
    }
}