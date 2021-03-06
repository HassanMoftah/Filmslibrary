﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
namespace WebApplication1
{
    public partial class ONEperson : System.Web.UI.Page
    {

        MOVIESEntities5 db = new MOVIESEntities5();
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
            personp imgs = NewMethod(img);
            byte[] bebo = imgs.persp;
            string ptr = Convert.ToBase64String(bebo);
            ImageMap1.Visible = true;
            ImageMap1.ImageUrl = "data:image;base64," + ptr;
            
           
        }

        private static personp NewMethod(IQueryable<personp> img)
        {
            return img.Single();
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
            if (state == "loggedin"&&!string.IsNullOrEmpty(userrate.Text.ToString()))
            {
                
                double userrat = Convert.ToDouble(userrate.Text.ToString());
                if (userrat >= 0 && userrat <= 10)
                {
                    double nrate = (cnofrate * crate + userrat) / (cnofrate + 1);
                    cnofrate++;

                    var person = db.people.Find(iD);
                    person.prate = nrate;
                    person.pnofrate = cnofrate;
                    db.SaveChanges();
                    Response.Redirect("ONEperson.aspx");
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