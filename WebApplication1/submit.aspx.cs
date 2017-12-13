using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class submit : System.Web.UI.Page
    {
        MOVIESEntities3 db = new MOVIESEntities3();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ss = (string)Session["status"];
            if(ss=="signup")
            {
                user us=new user();
                us.username = user.Text.ToString();
                us.userpassword = pass.Text.ToString();
                db.users.Add(us);
                db.SaveChanges();
                


                    Response.Redirect("HomePage.aspx");
                

            }
            else if(ss=="login")
            {
                string username = user.Text.ToString();
                var us = (from c in db.users where c.username == username
                          where c.userpassword == pass.Text.ToString() select c).SingleOrDefault();
                //adry
                if (us == null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('invalid user name or password');", true);
                }
                else
                {
                    Session["status"] = "loggedin";
                    Response.Redirect("HomePage.aspx");

                }
               
            }
        }
    }
}