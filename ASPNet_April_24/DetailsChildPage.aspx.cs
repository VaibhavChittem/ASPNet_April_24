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
    public partial class DetailsChildPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Product where ID = @a", con);
            cmd.Parameters.AddWithValue("@a", Request.QueryString["ID"]);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            lblProductName.Text = reader["ProductName"].ToString();
            lblCategory.Text = reader["Category"].ToString();
            lblPrice.Text = reader["Price"].ToString();
            imgDetails.ImageUrl = "ImageHandler.ashx?ID=" + Request.QueryString["ID"].ToString();
            con.Close();
        }
    }
}