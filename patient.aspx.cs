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
    public partial class patient : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["smartcon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            label1.Text = Session["user"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string[] s = new string[5];
            if (TextBox1.Text != "")
            {
                count += 1;
                s[0] = TextBox1.Text;
            }
            else if (TextBox2.Text != "")
            {
                count += 1;
                s[1] = TextBox2.Text;
            }
            else if (TextBox3.Text != "")
            {
                count += 1;
                s[2] = TextBox3.Text;
            }
            else if (TextBox4.Text != "")
            {
                count += 1;
                s[3] = TextBox4.Text;
            }

            else if (TextBox5.Text != "")
            {
                count += 1;
                s[4] = TextBox5.Text;
            }


            if (count == 5)
            {
                string[] ans = has5(s[0], s[1], s[2], s[3], s[4]);
                if (ans[0] == "No Ans")
                {
                    count--;
                }
                else
                {
                    for (int i = 0; i < ans.Length; i++)
                    {
                        TextBox6.Text += ans[i] + "\n";
                        Panel5.Visible = true;
                        Panel4.Visible = false;
                    }
                }
            }

            if (count == 4)
            {
                string[] ans = has4(s[0], s[1], s[2], s[3]);
                if (ans[0] == "No Ans")
                {
                    count--;
                }
                else
                {
                    for (int i = 0; i < ans.Length; i++)
                    {
                        TextBox6.Text += ans[i] + "\n";
                        Panel5.Visible = true;
                        Panel4.Visible = false;
                    }
                }
            }


            if (count == 3)
            {
                string[] ans = has3(s[0], s[1], s[2]);
                if (ans[0] == "No Ans")
                {
                    count--;
                }
                else
                {
                    for (int i = 0; i < ans.Length; i++)
                    {
                        TextBox6.Text += ans[i] + "\n";
                        Panel5.Visible = true;
                        Panel4.Visible = false;
                    }
                }
            }

            if (count == 2)
            {
                string[] ans = has2(s[0], s[1]);
                if (ans[0] == "No Ans")
                {
                    count--;
                }
                else
                {
                    for (int i = 0; i < ans.Length; i++)
                    {
                        Panel5.Visible = true;
                        Panel4.Visible = false;
                        TextBox6.Text += ans[i] + "\n";
                    }
                }
            }

            if (count == 1)
            {
                string[] ans = has1(s[0]);
                if (ans[0] == "No Ans")
                {
                    count--;
                }
                else
                {
                    for (int i = 0; i < ans.Length; i++)
                    {
                        Panel5.Visible = true;
                        Panel4.Visible = false;
                        TextBox6.Text += ans[i] + "\n";
                    }
                }
            }
            else
            {
                Panel5.Visible = false;
                Panel4.Visible = true;
            }
        }

        public string[] has5(string s1, string s2, string s3, string s4, string s5)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select diseasename from diseasetable Where s1 LIKE '%" + s1 + "%' OR  s2 LIKE '%" + s2 + "%' OR s3 LIKE '%" + s3 + "%' OR s4 LIKE '%" + s4 + "%' OR s5 LIKE '%" + s5 + "%'", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            int row = ds.Tables[0].Rows.Count;

            if (row != 0)
            {
                string[] ans = new string[row];

                for (int i = 0; i < row; i++)
                {
                    ans[i] = ds.Tables[0].Rows[i][0].ToString();
                }
                return ans;
            }
            else
            {
                string[] ans = { "No Ans" };
                return ans;
            }
        }



        public string[] has4(string s1, string s2, string s3, string s4)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select diseasename from diseasetable Where s1 LIKE '%" + s1 + "%' OR  s2 LIKE '%" + s2 + "%' OR s3 LIKE '%" + s3 + "%' OR s4 LIKE '%" + s4 + "%'", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            int row = ds.Tables[0].Rows.Count;

            if (row != 0)
            {
                string[] ans = new string[row];

                for (int i = 0; i < row; i++)
                {
                    ans[i] = ds.Tables[0].Rows[i][0].ToString();
                }
                return ans;
            }
            else
            {
                string[] ans = { "No Ans" };
                return ans;
            }
        }


        public string[] has3(string s1, string s2, string s3)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select diseasename from diseasetable Where s1 LIKE '%" + s1 + "%' OR  s2 LIKE '%" + s2 + "%' OR s3 LIKE '%" + s3 + "%'", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            int row = ds.Tables[0].Rows.Count;

            if (row != 0)
            {
                string[] ans = new string[row];

                for (int i = 0; i < row; i++)
                {
                    ans[i] = ds.Tables[0].Rows[i][0].ToString();
                }
                return ans;
            }
            else
            {
                string[] ans = { "No Ans" };
                return ans;
            }
        }



        public string[] has2(string s1, string s2)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select diseasename from diseasetable Where s1 LIKE '%" + s1 + "%' OR  s2 LIKE '%" + s2 + "%'", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            int row = ds.Tables[0].Rows.Count;

            if (row != 0)
            {
                string[] ans = new string[row];

                for (int i = 0; i < row; i++)
                {
                    ans[i] = ds.Tables[0].Rows[i][0].ToString();
                }
                return ans;
            }
            else
            {
                string[] ans = { "No Ans" };
                return ans;
            }
        }

        public string[] has1(string s1)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select diseasename from diseasetable Where s1 LIKE '%" + s1 + "%'", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            int row = ds.Tables[0].Rows.Count;

            if (row != 0)
            {
                string[] ans = new string[row];

                for (int i = 0; i < row; i++)
                {
                    ans[i] = ds.Tables[0].Rows[i][0].ToString();
                }
                return ans;
            }
            else
            {
                string[] ans = { "No Ans" };
                return ans;
            }
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}