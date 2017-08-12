using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SecurityProject.App_Code;
using System.Net.Http;

namespace SecurityProject
{
    public partial class NextPage : System.Web.UI.Page
    {
        private string GeneratedCode;
        protected void Page_Load(object sender, EventArgs e)
        {
           //if(Session["OTPCode"] !=null)
           //     GeneratedCode = Session["OTPCode"].ToString();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Query query = new Query();

            bool result=query.check(Session["Username"].ToString(), codeText.Text);

            if (result)
            {
                Response.Redirect("Welcome.aspx");
            }else
            {
                ErrorLabel.Text = "Your code is not correct";
            }

        }
    }
}