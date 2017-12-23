using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Actors : System.Web.UI.Page
    {
        MOVIESEntities5 db = new MOVIESEntities5();
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from p in db.people where p.job=="actor" select new { p.PID,p.Name, p.birth };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
           
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Redirect")
            {
                int index = Convert.ToInt32(e.CommandArgument);


                GridViewRow row = GridView1.Rows[index];
                string ss = row.Cells[2].Text;
                Session["person"] = ss;
                string g = row.Cells[1].Text.ToString();
                Session["personid"] = g;
                Response.Redirect("ONEperson.aspx");
            }
        }
    }
}