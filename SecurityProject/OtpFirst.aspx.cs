using SecurityProject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecurityProject
{
   

    public partial class OtpFirst : System.Web.UI.Page
    {
        private string url = "https://rest.nexmo.com/sms/json";
        string otpa;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenerateOtp(object sender, EventArgs e)
        {
            otpa = String.Empty;

            string alfhabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string small_alfhabet = "abcdefghijklmnopqrstuvwxyz";
            string number = "1234567890";
            string characters = number;

            if (RadioButtonList1.SelectedItem.Value == "1")
            {
                characters += alfhabet + small_alfhabet + number;



            }
            int length = int.Parse(DropDownList1.SelectedItem.Value);

            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;

                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();

                } while (otpa.IndexOf(character) != -1);
                otpa += character;
            }

            //Session["OTPCode"] = otpa;

            Query query = new Query();

            bool result = query.setCode(Session["Username"].ToString(),otpa);

            if(result)
                SendOTP(otpa, "8801761118890");

            // Label1.Text = otpa;


        }

        

        public async void SendOTP(string code, string toNumber)
        {
            IEnumerable<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("from","OTPCheck"),
                new KeyValuePair<string, string>("text","Your OTP code is: "+code),
                new KeyValuePair<string, string>("to",toNumber),
                new KeyValuePair<string, string>("api_key","f7d5d29e"),
                new KeyValuePair<string, string>("api_secret","afccf4a197e75307")
            };



            HttpContent jsonData = new FormUrlEncodedContent(data);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(url, jsonData);

                if (response.IsSuccessStatusCode)
                {
                    Session["OTPCode"] = otpa;
                    Response.Redirect("NextPage.aspx");
                }
            }

        }
}


}