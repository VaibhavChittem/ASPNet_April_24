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

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            cmdObj = new SqlCommand("usp_ProductDetails", conObj);
            cmdObj.CommandType = CommandType.StoredProcedure;
            //int len = fuImage.PostedFile.ContentLength;
            //byte[] imgbyte = new byte[len];
            //if (fuImage.HasFile)
            //{
            //    fuImage.PostedFile.InputStream.Read(imgbyte, 0, len);
            //}

            if (fuImage.HasFile)
            {
                string str = fuImage.FileName;
                fuImage.PostedFile.SaveAs(Server.MapPath("~/images/" + str));
                string Image1 = "~/images/" + str.ToString();

                cmdObj.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmdObj.Parameters.AddWithValue("@Category", ddlCategory.Text);
                cmdObj.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmdObj.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmdObj.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                cmdObj.Parameters.AddWithValue("@image1", Image1);
                lblImage.Text = Image1;
                if (conObj.State == ConnectionState.Closed)
                {
                    conObj.Open();
                }
                
            }

            //if (fuImage.HasFile)
            //{
            //    fuImage.SaveAs(Server.MapPath("images//" + fuImage.FileName));
            //    lblMessage.Text = "Image Uploaded";
            //    lblMessage.ForeColor = System.Drawing.Color.ForestGreen;
            //}
            //else
            //{
            //    lblMessage.Text = "Please Select your file";
            //    lblMessage.ForeColor = System.Drawing.Color.Red;
            //}
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