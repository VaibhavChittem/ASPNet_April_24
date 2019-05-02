using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet_April_24
{
    public partial class Header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                btnSignIn.Text = "SignOut";
            }
            else
            {
                btnSignIn.Text = "SignIn";
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            if (btnSignIn.Text == "SignIn")
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                btnSignIn.Text = "SignOut";
                Session.Clear();
                Response.Redirect("ChildPage.aspx");
            }
        }
    }
}