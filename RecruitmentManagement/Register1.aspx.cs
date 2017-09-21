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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SUYPC194;Initial Catalog=RecuritmentDb;User ID=sa;Password=Suyati123");
            SqlCommand cmd = new SqlCommand("HrInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("Email", TextBox2.Text);
            cmd.Parameters.AddWithValue("UserName", TextBox3.Text);
            cmd.Parameters.AddWithValue("Password", TextBox4.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("Register successfull!!");
            
        }
    }
}