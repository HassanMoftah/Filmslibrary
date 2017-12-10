using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class Movies : System.Web.UI.Page
    {

        MOVIESEntities3 DB = new MOVIESEntities3();

        protected void Page_Load(object sender, EventArgs e)
        {

            var query = from p in DB.films select new { p.ID,p.Title, p.Year, p.Gener };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="Redirect")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                
                GridViewRow row = GridView1.Rows[index];
                string ss =row.Cells[1].Text.ToString();
                Session["movieid"] = ss;
                Response.Redirect("ONEmovie.aspx");

                
            }
        }
    }
}