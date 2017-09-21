using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecruitmentManagement
{    
    public partial class Welcome : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=SUYPC194;Initial Catalog=RecuritmentDb;User ID=sa;Password=Suyati123");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Viewdata();
            }
        }
        protected void Viewdata()
        {
            SqlCommand cmd = new SqlCommand("select * from dbo.Candidate ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }      
        protected void Add_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCandidate.aspx");

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}