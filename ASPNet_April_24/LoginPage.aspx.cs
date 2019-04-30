using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet_April_24
{
    public partial class LoginPage : System.Web.UI.Page
    {
        private SqlConnection conObj = null;
        private SqlCommand cmdObj = null;
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtEmailID.Text;
            string pass = txtPassword.Text;
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj = new SqlCommand("select * from Customer where EmailID = @e  and Password= @p", conObj);
            conObj.Open();
            cmdObj.Parameters.AddWithValue("@e", user);
            cmdObj.Parameters.AddWithValue("@p", pass);
            SqlDataReader reader = cmdObj.ExecuteReader();
            if (reader.Read())
            {
                Response.Redirect("ChildPage.aspx?cust_ID="+reader["ID"].ToString());
            }
            //if ((txtEmailID.Text == Request.QueryString["EmailID"]) && (txtPassword.Text == Request.QueryString["Password"]))
            //{
                
            //}
            else
            {
                lblErrorMessage.Text = "Email and Password are not matched";
            }

        }
    }
}