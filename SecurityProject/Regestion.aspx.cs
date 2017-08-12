using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SecurityProject
{
    public partial class Regestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnRegSub_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=Nahid-desktop/SQLEXPRESS;Initial Catalog=LICT;Trusted_Connection=true";
            SqlConnection connection = new SqlConnection(connectionString);
            // string connection = ConfigurationManager.ConnectionStrings["connection"].ToString();
            //SqlConnection conn = new SqlConnection(connection);

            string query = "INSERT INTO [tbl_UserT] (First_Name,Last_Name,Dob,Country,State,Email,Phone,Password) Values(@First_Name,@Last_Name,@Dob,@Country,@State,@Email,@Phone,@password)";

            SqlCommand command = new SqlCommand(query, connection);

            SqlParameter Userparameter = new SqlParameter();

            Userparameter.ParameterName = "@First_Name";
            Userparameter.Value = txtFname.Text;
            command.Parameters.Add(Userparameter);

            SqlParameter Lstnamepara = new SqlParameter();
            Lstnamepara.ParameterName = "@Last_Name";
            Lstnamepara.Value = txtLName.Text;
            command.Parameters.Add(Lstnamepara);

            SqlParameter DoBpara = new SqlParameter();
            DoBpara.ParameterName = "@DoB";
            DoBpara.Value = txtDoB.Text;
            command.Parameters.Add(DoBpara);

            SqlParameter Conpara = new SqlParameter();
            Conpara.ParameterName = "@Country";
            Conpara.Value = txtCountry.Text;
            command.Parameters.Add(Conpara);

            SqlParameter Statepara = new SqlParameter();
            Statepara.ParameterName = "@State";
            Statepara.Value = txtState.Text;
            command.Parameters.Add(Statepara);


            SqlParameter Emailpara = new SqlParameter();
            Emailpara.ParameterName = "@Email";
            Emailpara.Value = txtEmail.Text;
            command.Parameters.Add(Emailpara);

            SqlParameter Phonpara = new SqlParameter();
            Phonpara.ParameterName = "@Phone";
            Phonpara.Value = txtDoB.Text;
            command.Parameters.Add(Phonpara);

            SqlParameter Passpara = new SqlParameter();
            Passpara.ParameterName = "@Password";
            Passpara.Value = txtPass.Text;
            command.Parameters.Add(Passpara);

            connection.Open();
            if (CheckBox1.Checked)
            {
               int Result = command.ExecuteNonQuery();
               if (Result == 1)
               {

                    Response.Redirect("login.aspx");
                    


                }
                else
              {
                   Response.Write("Not ful");
                  connection.Close();
                }
            }
           

}






    }
}