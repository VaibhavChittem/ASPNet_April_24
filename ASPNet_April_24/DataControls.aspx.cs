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
    public partial class DataControls : System.Web.UI.Page
    {
        private SqlConnection conObj = null;
        private SqlDataAdapter adapter = null;
        private DataSet dataSet = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = GetEmployeeData();
                dlProducts.DataSource = ds.Tables["Product"];
                dlProducts.DataBind();
            }
        }

        public DataSet GetEmployeeData()
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            adapter = new SqlDataAdapter("Select ID,Productname,Category,Price,image1 from Product", conObj);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "Product");
            return dataSet;
        }

        protected void dlProducts_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Details")
            {
                Response.Redirect("EmployeeProfilePage.aspx?ID=" + e.CommandArgument);
            }
        }
    }
}