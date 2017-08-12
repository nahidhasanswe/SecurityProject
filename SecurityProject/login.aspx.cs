using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace SecurityProject
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Nahid-desktop\\SQLEXPRESS;Initial Catalog=LICT;Trusted_Connection=true";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "select * from [tbl_UserT]  where Email='" + txtUserId.Text + "' and Password='" + txtLogPass.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["Username"] = txtUserId.Text;
                Response.Redirect("OtpFirst.aspx");
            }
            else
            {
                Response.Write("Invalid Username Or Password");
                txtUserId.Text = "";
                txtLogPass.Text = "";
            }
        }
    }
}