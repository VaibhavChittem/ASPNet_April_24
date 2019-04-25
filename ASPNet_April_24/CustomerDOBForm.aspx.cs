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
    public partial class CustomerDOBForm : System.Web.UI.Page
    {
        private SqlConnection conObj = null;
        private SqlCommand cmdObj = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSearch_Click(object sender, EventArgs e)
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj = new SqlCommand("usp_Dates",conObj);
            cmdObj.CommandType = CommandType.StoredProcedure;
            cmdObj.Parameters.AddWithValue("@FromDate", txtFromDate.Text);
            cmdObj.Parameters.AddWithValue("@ToDate", txtToDate.Text);
            if (conObj.State == ConnectionState.Closed)
            {
                conObj.Open();
            }
            SqlDataReader sqlDataReader = cmdObj.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                gvSearch.DataSource = sqlDataReader;
                gvSearch.DataBind();
            }
            conObj.Close();
        }
    }
}