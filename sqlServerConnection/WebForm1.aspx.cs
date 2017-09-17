using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace sqlServerConnection
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            using (SqlConnection con = new SqlConnection("Data Source=PRADEEP\\SQLEXPRESS; Initial Catalog=product;Integrated Security=true")) 
            {
                //SqlCommand cmd = new SqlCommand("select * from tblProduct", con);
                //or
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from tblProduct";
                cmd.Connection = con;

                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
            
        }

        
    }
}