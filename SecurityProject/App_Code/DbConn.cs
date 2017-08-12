using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SecurityProject.App_Code
{
    public static class DBConn
    {
        public static SqlConnection getConn()
        {
            string connectionString = "Data Source=Nahid-desktop\\SQLEXPRESS;Initial Catalog=LICT;Trusted_Connection=true";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }

    public class Query
    {
        public bool setCode(string userId,string code)
        {
            SqlConnection con = DBConn.getConn();

            string query = "INSERT INTO [OTPTable] (UserID,OTPCode) Values(@UserId,@OTPCode)";
            SqlCommand command = new SqlCommand(query, con);

            SqlParameter Userparameter = new SqlParameter();

            Userparameter.ParameterName = "@UserId";
            Userparameter.Value = userId;
            command.Parameters.Add(Userparameter);

            SqlParameter Lstnamepara = new SqlParameter();
            Lstnamepara.ParameterName = "@OTPCode";
            Lstnamepara.Value = code;
            command.Parameters.Add(Lstnamepara);

            con.Open();

            int result = command.ExecuteNonQuery();

            if (result == 1)
                return true;
            else
                return false;

        }

        public bool delete(string userId)
        {
            SqlConnection con = DBConn.getConn();

            string query = "DELETE FROM [OTPTable] WHERE UserID=@userName";

            SqlCommand command = new SqlCommand(query, con);

            SqlParameter Userparameter = new SqlParameter();

            Userparameter.ParameterName = "@userName";
            Userparameter.Value = userId;
            command.Parameters.Add(Userparameter);

            con.Open();
            int reult = command.ExecuteNonQuery();

            if (reult == 1)
                return true;
            else
                return false;
        }

        public bool check(string userId,string code)
        {
            SqlConnection con = DBConn.getConn();

            string query = "select * from [OTPTable]  where UserID='" + userId + "' and OTPCode='" + code + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return delete(userId);
            }
            else
            {
                return false;
            }
        }
    }
}