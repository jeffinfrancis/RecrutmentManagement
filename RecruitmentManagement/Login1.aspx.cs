using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecruitmentManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=.;uid=sa;pwd=Password$2;database=roham";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand com = new SqlCommand("CUser", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("username", TextBox1.Text);
            SqlParameter p2 = new SqlParameter("password", TextBox2.Text);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            con.Open();
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                Label1.Text = "Login successful.";
                Label1.Visible = true;
            }
            else
            {
                Label1.Text = "Invalid username or password.";
                Label1.Visible = true;
            }
        }
    }
}