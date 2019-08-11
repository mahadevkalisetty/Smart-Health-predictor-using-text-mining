using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Smart_healthpredictor
{
    public partial class viewdiseases : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["smartcon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            string Query = "select * from diseasetable";
            SqlCommand cmd = new SqlCommand(Query, con);
            using (SqlDataAdapter sd = new SqlDataAdapter()) 
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }



        }
    }
}