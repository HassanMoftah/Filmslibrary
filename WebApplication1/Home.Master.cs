using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {
            string ses = (string)Session["status"];
            if (ses == "loggedin")
            {
                SIGNUP.Visible = false;
                login.Visible = false;
                name.Text = "Welcome " + Session["username"].ToString(); 
            }
            else
            {
                name.Visible = false;
                SIGNUP.Visible = true;
                login.Visible = true;
                name.Text = "";
            }
        }

        protected void SIGNUP_Click(object sender, EventArgs e)
        {
            Session["status"] = "signup";
            Response.Redirect("submit.aspx");
        }

        protected void login_Click(object sender, EventArgs e)
        {
            Session["status"] = "login";
            Response.Redirect("submit.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["status"] = "";
            Page_Load(sender, e);
        }
    }
}