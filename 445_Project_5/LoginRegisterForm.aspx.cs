using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace _445_Project_5
{
    public partial class LoginRegisterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
        }

          public bool checkUserNameAndPassword(string userName, string passWord)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNodeList users = xmlDoc.GetElementsByTagName("users")[0].ChildNodes;

            foreach (XmlNode userNode in users)
            {
                string username = userNode.SelectSingleNode("username").InnerText;
                string password = userNode.SelectSingleNode("password").InnerText;

                if (username.CompareTo(userName) == 0 && password.CompareTo(passWord) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public void addUser(string userName, string passWord)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlElement root = xmlDoc.DocumentElement;

            XmlElement lastUser = (XmlElement)root.LastChild;// get the last user element 
            int id = int.Parse(lastUser.Name.Replace("user-", "")) + 1; //last user + 1
            XmlElement newUser = xmlDoc.CreateElement("user-" + id); // creating a new user with a new number
            XmlElement username = xmlDoc.CreateElement("username");// creating username element
            username.InnerText = userName;//setting username element
            XmlElement password = xmlDoc.CreateElement("password");//creating password element
            password.InnerText = passWord;//setting password element 
            newUser.AppendChild(username);//appending to user element 
            newUser.AppendChild(password);//appending to user element
            root.AppendChild(newUser);//appending to root
            xmlDoc.Save(filePath); //saving 
        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            string messageIncorrect = "Incorrect user name or password!";
            string scriptIncorrect = @"<script type='text/javascript'>alert('" + messageIncorrect + "');</script>";

            if (checkUserNameAndPassword(txtUserName.Value.Trim(), txtUserPass.Value))
            {
                FormsAuthenticationTicket tkt;
                string cookiestr;
                HttpCookie ck;
                tkt = new FormsAuthenticationTicket
                    (1, // version number
                    txtUserName.Value, // user name value
                    DateTime.Now, // time now to ensure correct expiration timer
                    DateTime.Now.AddMinutes(30), //expiration
                    chkPersistCookie.Checked,  // Whether the ticket is persistent
                    txtUserName.Value.Trim()); // data i want to pass

                cookiestr = FormsAuthentication.Encrypt(tkt); // Encrypt the authentication ticket
                // Create a new cookie with the encrypted ticket
                ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                if (chkPersistCookie.Checked) //checking if user clicked yes to persistant cookies
                    ck.Expires = tkt.Expiration; //Setting Http cookie expiration date to forms authentication ticket expiration date
                ck.Path = FormsAuthentication.FormsCookiePath; //setting the path for http cookie
                Response.Cookies.Add(ck); // adding Http cookie to the response cookies

                string strRedirect;// redirect url string 
                strRedirect = Request["ReturnUrl"];
                if (strRedirect == null)
                    strRedirect = "default.aspx";
                Response.Redirect(strRedirect, true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", scriptIncorrect);
            }
        }

        protected void Register_Button_Click(object sender, EventArgs e)
        {

            string messageIncorrect = "User already exists!";
            string scriptIncorrect = @"<script type='text/javascript'>alert('" + messageIncorrect + "');</script>";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            bool doesUserExist = false;
            XmlNodeList users = xmlDoc.GetElementsByTagName("users")[0].ChildNodes;

            foreach (XmlNode userNode in users)
            {
                string username = userNode.SelectSingleNode("username").InnerText;
                if (username == txtUserName.Value.Trim())
                {
                    doesUserExist = true;
                }
            }
            if (doesUserExist)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", scriptIncorrect);
                return;
            }
            addUser(txtUserName.Value.Trim(), txtUserPass.Value);
        }
    }
}