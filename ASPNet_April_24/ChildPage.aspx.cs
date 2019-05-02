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
    public partial class ChildPage : System.Web.UI.Page
    {
        private SqlConnection conObj = null;
        private SqlDataAdapter adapter = null;
        private DataSet dataSet = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    GetEmployeeData();
                Session["User"]=Request.QueryString["Cust_ID"];
                //dlProducts.DataSource = ds.Tables["Product"];
                //dlProducts.DataBind();
            }
        }
        public void GetEmployeeData()
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            adapter = new SqlDataAdapter("Select * from Product", conObj);
            dataSet = new DataSet();
            adapter.Fill(dataSet,"Product");
            dlProducts.DataSource = dataSet.Tables["Product"];
            dlProducts.DataBind();
            //return dataSet;
        }
        protected void dlProducts_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Session["User"] = Request.QueryString["Cust_ID"];
            if (e.CommandName == "Details")
            {
                Response.Redirect("DetailsChildPage.aspx?ID=" + e.CommandArgument);
            }
            else if (e.CommandName == "BuyNow")
            {
                if (Session["User"] != null)
                {
                    Response.Redirect(string.Format("OrderDetailChildPage.aspx?pID=" + e.CommandArgument + "&cid=" + Request.QueryString["Cust_ID"]));
                 }
                else
                {
                    Response.Redirect("LoginPage.aspx");
                }

            }
        }
    }
}