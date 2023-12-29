using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _445_Project_5
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //staff page 1
            Button loginButton = (Button)Master.FindControl("Login_Button");
            Button logOutButton = (Button)Master.FindControl("LogOut_Button");
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];

            // Decrypt the authentication ticket
            if (authCookie == null)
            {
                loginButton.Visible = true;
                logOutButton.Visible = false;
                Services_Div.Visible = false;
                Invalid_User_Div.Visible = false;
                User_Logged_Out_Div.Visible = true;
                FormsAuthentication.SignOut();
                Session.Abandon();
            }
            else
            {
                FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                // Retrieve the custom data    
                string customData = authTicket.UserData;
                loginButton.Visible = false;
                logOutButton.Visible = true;
                if (customData.CompareTo("TA1") == 0)
                {
                    Services_Div.Visible = true;
                    Invalid_User_Div.Visible = false;
                    User_Logged_Out_Div.Visible = false;
                    Welcome_Label.Text += " " + customData + "! Enjoy the services!";
                }
                else
                {
                    Services_Div.Visible = false;
                    Invalid_User_Div.Visible = true;
                    User_Logged_Out_Div.Visible = false;
                }
            }
        }

        protected void URL_Text_Box_TextChanged(object sender, EventArgs e)
        {
        }

        protected void URL_Download_Button_Click(object sender, EventArgs e)
        {

            string url = URL_Text_Box.Text;
            if (URL_Text_Box.Text.Length > 0)
            {
                DownloadDataService.Service1Client client = new DownloadDataService.Service1Client();
                Label1.Text = "Loading...";
                string response = client.DownloadData(url);
                Label1.Text = response;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string zipcode = ZipCodeTextBox.Text;
            if (ZipCodeTextBox.Text.Length >= 5)
            {
                Uri uri = new Uri("http://webstrar23.fulton.asu.edu/Page9/Service1.svc/weather/forecast/" + zipcode.Trim());
                WebClient webClient = new WebClient();
                string response = webClient.DownloadString(uri);
                string[] weather = response.Split(',');
                WeatherLabel.Text = weather[0];
                WeatherLabel0.Text = weather[1];
                WeatherLabel1.Text = weather[2];
                WeatherLabel2.Text = weather[3];
                WeatherLabel3.Text = weather[4];
            }
        }
    }
}