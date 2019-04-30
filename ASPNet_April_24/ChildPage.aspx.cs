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
                //DataSet ds = 
                    GetEmployeeData();
                Session["User"] = Request.QueryString["ID"];
                //dlProducts.DataSource = ds.Tables["Product"];
                //dlProducts.DataBind();
            }
        }

        public void GetEmployeeData()
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            adapter = new SqlDataAdapter("Select * from Product", conObj);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "Product");
            dlProducts.DataSource = dataSet.Tables["Product"];
            dlProducts.DataBind();
            //return dataSet;
        }

        protected void dlProducts_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Session["User"] = Request.QueryString["ID"];
            if (e.CommandName == "Details")
            {
                Response.Redirect("DetailsChildPage.aspx?ID=" + e.CommandArgument);
            }
            else if (e.CommandName == "BuyNow")
            {
                if (string.IsNullOrEmpty(Session["User"] as string))
                {
                    Response.Redirect("LoginPage.aspx");
                }
                else
                {
                    Response.Redirect(string.Format("OrderDetailChildPage.aspx?pID="+e.CommandArgument+ "&cid=" +Request.QueryString["ID"].ToString()));
                }

            }
        }
    }
}