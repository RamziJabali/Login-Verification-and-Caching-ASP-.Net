using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace _445_Project_5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button loginButton = (Button)Master.FindControl("Login_Button");
            Button logOutButton = (Button)Master.FindControl("LogOut_Button");
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];

            // Decrypt the authentication ticket
            if (authCookie == null)
            {
                loginButton.Visible = true;
                logOutButton.Visible = false;
                FormsAuthentication.SignOut();
                Session.Abandon();
                WelcomeUserDiv.Visible = false;
            }
            else
            {
                loginButton.Visible = false;
                logOutButton.Visible = true;
                WelcomeUserDiv.Visible = true;
                FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                // Retrieve the custom data    
                string customData = authTicket.UserData;
                Label_Welcome.Text = "Welcome:";
                Label_UserName.Text = customData;
            }
        }
    }
}
