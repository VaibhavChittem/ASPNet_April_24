using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet_April_24
{
    public partial class ProductForm : System.Web.UI.Page
    {
        private SqlConnection conObj = null;
        private SqlCommand cmdObj = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string con = ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString;
                using (SqlConnection c = new SqlConnection(con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("select * from Product", con))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        gvImages.DataSource = dt;
                        gvImages.DataBind();
                    }
                }
            }
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                /*string imageUrl = "@image,"*//* + Convert.ToBase64String((byte[])dr["image1"])*/
                string imgUrl = Server.MapPath("@image1");
                (e.Row.FindControl("Image1") as Image).ImageUrl = imgUrl;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj = new SqlCommand("usp_ProductDetails", conObj);
            cmdObj.CommandType = CommandType.StoredProcedure;
            int len = fuImage.PostedFile.ContentLength;
            byte[] imgbyte = new byte[len];
            fuImage.PostedFile.InputStream.Read(imgbyte, 0, len);

            
                //string str = fuImage.FileName;
                //fuImage.PostedFile.SaveAs(Server.MapPath("~/images/" + str));
                //string Image1 = "~/images/" + str.ToString();

                cmdObj.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmdObj.Parameters.AddWithValue("@Category", ddlCategory.Text);
                cmdObj.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmdObj.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmdObj.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                cmdObj.Parameters.AddWithValue("@image1", imgbyte);
                //lblImage.Text = Image1;
                if (conObj.State == ConnectionState.Closed)
                {
                    conObj.Open();
                }
            int result = cmdObj.ExecuteNonQuery();
            if (result > 0)
            {
                lblMessage.Text = "New Product Added";
            }
            else
            {
                lblMessage.Text = "Error";
            }
            if (conObj != null)
            {
                conObj.Close();
            }
        }

    }
}