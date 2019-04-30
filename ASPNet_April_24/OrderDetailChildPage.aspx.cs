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
    public partial class OrderDetailChildPage : System.Web.UI.Page
    {
        SqlConnection conObj = null;
        SqlConnection conObj1 = null;
        SqlConnection conObj2 = null;
        SqlCommand cmdObj = null;
        SqlCommand cmdObj1 = null;
        SqlCommand cmdObj2 = null;
        SqlDataReader r = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCustomerID.Text = Request.QueryString["cID"];
            lblProductID.Text = Request.QueryString["pID"];
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj = new SqlCommand("select * from Product where ID=@id",conObj);
            if (conObj2.State == ConnectionState.Closed)
            {
                conObj2.Open();
            }
            cmdObj.Parameters.AddWithValue("@id", Request.QueryString["pID"]);
            r = cmdObj.ExecuteReader();
        }

        protected void ddlDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            conObj2 = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj2 = new SqlCommand("select * from Product where ID=@id", conObj);
            conObj2.Open();
            cmdObj2.Parameters.AddWithValue("@id", Request.QueryString["@id"].ToString());
            SqlDataReader reader = cmdObj2.ExecuteReader();
            reader.Read();
            double quant = Convert.ToDouble(ddlDropDownList.SelectedItem.Value.ToString());
            double price = Convert.ToDouble(reader["Price"].ToString());
            lblTotalPrice.Text = (quant * price).ToString();
            reader.Close();
            conObj2.Close();
        }
    }
}