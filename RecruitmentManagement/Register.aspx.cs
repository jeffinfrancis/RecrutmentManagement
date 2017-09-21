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
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SUYPC194;Initial Catalog=RecuritmentDb;User ID=sa;Password=Suyati123");
            SqlCommand cmd = new SqlCommand("HrInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Name", Name.Text);
            cmd.Parameters.AddWithValue("Email", Email.Text);
            cmd.Parameters.AddWithValue("UserName", UserName.Text);
            cmd.Parameters.AddWithValue("Password", Password.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("Register successfull!!");
        }
    }
}