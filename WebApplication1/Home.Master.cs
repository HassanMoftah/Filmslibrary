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
            if (ses == "loggenin")
            {
                SIGNUP.Text = "signed";
                login.Text = "loggedin";
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
        }
    }
}