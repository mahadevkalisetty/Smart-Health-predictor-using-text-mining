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
    public partial class Doctor_login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["smartcon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
           
        }
        protected void Login_Click1(object sender, EventArgs e)
        {
             string txt="";
            con.Open();   
            string p = "select * from Register where email='" + lemail.Text + "' and password='" + lpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(p,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt = dr[2].ToString();
            }
            if (txt == lemail.Text)
            {
                Response.Redirect("Doctor.aspx");

            }
            else {
                Response.Write("invalid password");
            }
        }
        protected void Reges_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel1.Visible = true;    
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }


        protected void Register_Click(object sender, EventArgs e)
        {
  
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Register values('"+ firstname.Text + "','" + lastname.Text + "','" + email.Text + "','" + password.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Doctor_login.aspx");
            
        }
        
    }
}