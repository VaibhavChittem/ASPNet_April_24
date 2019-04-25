using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet_April_24
{
    public partial class CustomerForm : System.Web.UI.Page
    {
        private SqlConnection conObj = null;
        private SqlCommand cmdObj = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumbit_Click(object sender, EventArgs e)
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj = new SqlCommand("usp_CustomerInsert", conObj);
            cmdObj.CommandType = CommandType.StoredProcedure;
            cmdObj.Parameters.AddWithValue("@FirstName",txtFirstName.Text);
            cmdObj.Parameters.AddWithValue("@LastName", txtlastName.Text);
            cmdObj.Parameters.AddWithValue("@EmailID", txtEmailID.Text);
            cmdObj.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmdObj.Parameters.AddWithValue("@DOB", dtDOB.Text);
            cmdObj.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
            cmdObj.Parameters.AddWithValue("@Address", txtAddress.Text);

            if (conObj.State == ConnectionState.Closed)
            {
                conObj.Open();
            }
            int result = cmdObj.ExecuteNonQuery();
            if (result > 0)
            {
                lblMessage.Text = "New Employee Created";
            }
            else
            {
                lblMessage.Text = "Error";
            }

        }

        //protected void btnReset_Click(object sender, EventArgs e)
        //{
        //    txtFirstName.Text = "";
        //    txtlastName.Text = "";
        //    txtEmailID.Text = "";
        //    dtDOB.Text = "";
        //    txtMobileNo.Text = "";
        //    txtAddress.Text = "";

        //}
    }
}