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
    public partial class Contact : Page
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
                if (customData.CompareTo("TA2") == 0)
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fah = TextBox1.Text;
            if (TextBox1.Text.Length > 0)
            {
                Uri uri = new Uri("http://webstrar23.fulton.asu.edu/page4/Service1.svc/fah/to/cel/" + fah.Trim());
                WebClient webClient = new WebClient();
                string response = webClient.DownloadString(uri);
                Label1.Text = response;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string cel = TextBox2.Text;
            if (TextBox1.Text.Length > 0)
            {
                Uri uri = new Uri("http://webstrar23.fulton.asu.edu/page4/Service1.svc/cel/to/fah/" + cel.Trim());
                WebClient webClient = new WebClient();
                string response = webClient.DownloadString(uri);
                Label2.Text = response;
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}