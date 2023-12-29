<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="_445_Project_5.Contact" enableEventValidation="false"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="Invalid_User_Div" runat="server">
        <h1>Please Login as staff to access this Page</h1>
        <h2>How Can I Access Staff 2 page?</h2>
        <p>Please refrence welcome page for clear instructions on how to access Staff 2 Page</p>
    </div>
    <div id="User_Logged_Out_Div" runat="server">
        <h1>You are currently not logged in</h1>
        <h2>Please Login as staff to access this page</h2>
        <h2>How Can I Access Staff 2 page?</h2>
        <p>Please refrence welcome page for clear instructions on how to access Staff 2 Page</p>
    </div>
    <div id="Services_Div" runat="server">
        <h2>Staff Page 2</h2>
        <asp:Label ID="Welcome_Label" runat="server" Text="Welcome" />
        <h2>fahrenheit to celsius service:</h2>
        <p class="lead">
            Description: Allows user to convert fahrenheit to celsius and returns a string of the conversion
        </p>
        <p class="lead">
            &nbsp;URL for the service : http://webstrar23.fulton.asu.edu/page4/Service1.svc
        </p>
        <p class="lead">
            Method: string f2c(string fahrenheit);
        </p>
        <p class="lead">
            Enter fahrenheit to convert
        </p>
        <p class="lead">
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p class="lead">
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p class="lead">
            celsius to fahrenheit service:
        </p>
        <p class="lead">
            Description: Allows user to convert celsius to fahrenheit and returns a string of the conversion
        </p>
        <p class="lead">
            &nbsp;URL for the service : http://webstrar23.fulton.asu.edu/page4/Service1.svc
        </p>
        <p class="lead">
            Method: string c2f(string celsius);
        </p>
        <p class="lead">
            Enter celsius to convert
        </p>
        <p class="lead">
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </p>
        <p class="lead">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>

    </div>

</asp:Content>
