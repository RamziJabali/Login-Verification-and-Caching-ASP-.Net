<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="_445_Project_5.About" enableEventValidation="false"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="Invalid_User_Div" runat="server">
        <h1>Please Login as staff to access this Page</h1>
        <h2>How Can I Access Staff 1 page?</h2>
        <p>Please refrence welcome page for clear instructions on how to access Staff 1 Page</p>
    </div>
    <div id="User_Logged_Out_Div" runat="server">
        <h1>You are currently not logged in</h1>
        <h2>Please Login as staff 1 to access this page</h2>
        <h2>How Can I Access Staff 1 page?</h2>
        <p>Please refrence welcome page for clear instructions on how to access Staff 1 Page</p>
    </div>
    <div id="Services_Div" runat="server">
        <h2>Staff Page 1</h2>
        <asp:Label ID="Welcome_Label" runat="server" Text="Welcome" />
        <p class="lead">WebDownloading:</p>
        <p class="lead">Description: It takes a URL in string as input and returns the content at the given URL.</p>
        <p class="lead">URL for the service : <a href="http://webstrar23.fulton.asu.edu/page3/Service1.svc">http://webstrar23.fulton.asu.edu/page5/Service1.svc</a></p>
        <p class="lead">Method: String WebDownloading(String URL)</p>
        <p class="lead">
            <asp:TextBox ID="URL_Text_Box" runat="server" OnTextChanged="URL_Text_Box_TextChanged">www.</asp:TextBox>
        </p>
        <p class="lead">
            <asp:Button ID="URL_Download_Button" runat="server" Text="Download Web Page" OnClick="URL_Download_Button_Click" />
        </p>
        <p class="lead">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <p class="lead">Weather Service:</p>
        <p class="lead">
            Description: Creates a 5-day weather forecast service of zipcode location based on the OpenWeather Free API
        </p>
        <p class="lead">
            URL for the service : <a href="http://webstrar23.fulton.asu.edu/page5/Service1.svc">http://webstrar23.fulton.asu.edu/page5/Service1.svc</a>
        </p>
        <p class="lead">
            Method: List&lt;String&gt; WeatherService(String ZipCode)
        </p>
        <p class="lead">
            <asp:TextBox ID="ZipCodeTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p class="lead">
            <asp:Label ID="WeatherLabel" runat="server" Text=""></asp:Label>
        </p>
        <p class="lead">
            <asp:Label ID="WeatherLabel0" runat="server" Text=""></asp:Label>
        </p>
        <p class="lead">
            <asp:Label ID="WeatherLabel1" runat="server" Text=""></asp:Label>
        </p>
        <p class="lead">
            <asp:Label ID="WeatherLabel2" runat="server" Text=""></asp:Label>
        </p>
        <p class="lead">
            <asp:Label ID="WeatherLabel3" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
