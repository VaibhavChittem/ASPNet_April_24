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
        SqlDataReader reader1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCustomerID.Text = Request.QueryString["ciD"];
            lblProductID.Text = Request.QueryString["pID"];
            lblOrderDate.Text = DateTime.Now.ToString();
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj = new SqlCommand("select * from Product where ID=@id",conObj);
            if (conObj.State == ConnectionState.Closed)
            {
                conObj.Open();
            }
            cmdObj.Parameters.AddWithValue("@id", Request.QueryString["pID"]);
            r = cmdObj.ExecuteReader();
            r.Close();
            conObj.Close();

        }

        protected void ddlDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            conObj2 = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj2 = new SqlCommand("select * from Product where ID=@id", conObj2);
            conObj2.Open();
            cmdObj2.Parameters.AddWithValue("@id", Request.QueryString["pID"]);
            reader1 = cmdObj2.ExecuteReader();
            reader1.Read();
            int quant = Convert.ToInt32(ddlDropDownList.SelectedItem.Value);
            int price = Convert.ToInt32(reader1["Price"]);
            lblTotalPrice.Text = (quant * price).ToString();
            reader1.Close();
            conObj2.Close();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            conObj1 = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj1 = new SqlCommand("insert into OrderDetail(Product_ID,CustomerID,TotalPrice,TotalQuantity,OrderDate) values" +
                "(@Product_ID,@CustomerID,@TotalPrice,@TotalQuantity,@OrderDate)", conObj1);
            conObj1.Open();
            cmdObj1.Parameters.AddWithValue("@Product_ID", Convert.ToInt32(lblProductID.Text));
            cmdObj1.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(lblCustomerID.Text));
            cmdObj1.Parameters.AddWithValue("@TotalPrice", lblTotalPrice.Text);
            cmdObj1.Parameters.AddWithValue("@TotalQuantity", Convert.ToInt32(ddlDropDownList.Text));
            cmdObj1.Parameters.AddWithValue("@OrderDate", DateTime.Now);

            //if (conObj1.State == ConnectionState.Closed)
            //{
            //    conObj1.Open();
            //}
            int res = cmdObj1.ExecuteNonQuery();
            if (res > 0)
            {
                conObj1 = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
                SqlCommand cmdUpdate = new SqlCommand("Update OrderDetail set TotalQuantity = @newQuantity where OrderID=@OrderID",conObj1);
                cmdUpdate.Parameters.AddWithValue("", 10);
                lblMessageForOrderDetail.Text = "Added to OrderDetail Table";
            }
        }
    }
}