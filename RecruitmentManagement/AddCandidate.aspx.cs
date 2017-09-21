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
    public partial class AddCandidate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
          using(SqlConnection con = new SqlConnection("Data Source=SUYPC194;Initial Catalog=RecuritmentDb;User ID=sa;Password=Suyati123"))
          {
            using(SqlCommand cmd = new SqlCommand("CandidateInsert", con))
            {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Name", Name.Text);
            cmd.Parameters.AddWithValue("PAN", PAN.Text);
            cmd.Parameters.AddWithValue("InterviewDate", Convert.ToDateTime(InterviewDate.Text));
            cmd.Parameters.AddWithValue("Levels", Levels.Text);
            cmd.Parameters.AddWithValue("Status", Status.Text);
            cmd.Parameters.AddWithValue("AddedBy", AddedBy.Text);
            con.Open();
            int result =(int) cmd.ExecuteNonQuery();
            if(result.count()>0)
            {
            Response.Redirect("Welcome.aspx");
            }
            else
            {
            lbl_msg.Text=ConfigurationManager.AppSettings["User not registered"];
            }
           }
          }
        }
    }
}
