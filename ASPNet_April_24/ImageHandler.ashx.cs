using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASPNet_April_24
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string id = context.Request.QueryString["Id"].ToString();
            SqlConnection conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select image1 from Product Where ID=@Id", conObj);
            cmd.Parameters.AddWithValue("@Id", id);
            if (conObj.State == ConnectionState.Closed)
            {
                conObj.Open();
            }
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (rdr.HasRows)
            {
                rdr.Read();
            }
            context.Response.BinaryWrite((byte[])rdr["image1"]);
            context.Response.End();
            conObj.Close();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}