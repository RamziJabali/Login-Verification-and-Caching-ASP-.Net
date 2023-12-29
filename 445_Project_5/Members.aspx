<%@ Page Title="Members" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Members.aspx.cs" Inherits="_445_Project_5.Members" enableEventValidation="false"%>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="Invalid_User_Div" runat="server">
        <h1>Please Login as a Member to access this Page</h1>
        <h2>How Can I Access Members page?</h2>
        <p>Please refrence welcome page for clear instructions on how to access Members Page</p>
    </div>
    <div id="User_Logged_Out_Div" runat="server">
        <h1>You are currently not logged in</h1>
        <h2>Please Login as a Member to access this page</h2>
        <h2>How Can I Access Members page?</h2>
        <p>Please refrence welcome page for clear instructions on how to access Members Page</p>
    </div>
    <div id="Services_Div" runat="server">
        <h2>Members</h2>
        <asp:Label ID="Welcome_Label" runat="server" Text="Welcome" />
         <h2>
            sort Text service:</h2>
        <p class="lead">
            Description: Allows user to enter text EX: "5,4,3,2,1" and it will sort it -> "1,2,3,4,5"</p>
        <p class="lead">
            &nbsp;URL for the service :http://webstrar23.fulton.asu.edu/page4/Service1.svc</p>
        <p class="lead">
            Method:  string sort(string text);</p>
     <p class="lead">
            Enter numbers separated by ',' to sort</p>
     <p class="lead">
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
     </p>
     <p class="lead">
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
     </p>
     <p class="lead">
            <asp:Label ID="Label3" runat="server"></asp:Label>
     </p>
           <h2>Currency Service:</h2>
        <p class="lead">
            Description: Allows user to pick and convert from 5 currencies of their choice and allows them to enter an amount they would like to convert.</p>
        <p class="lead">
            &nbsp;Based on <a href="https://fixer.io">https://fixer.io</a> free API allowed only 100 uses per month
        </p>
        <p class="lead">
            &nbsp;URL for the service : http://webstrar23.fulton.asu.edu/page2/Service1.svc</p>
        <p class="lead">
            Method: string currenecyConverter(string from, string to, string amount);</p>
        <p class="lead">
            FROM:</p>
        
    <p class="lead">
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="USD">United States Dollar</asp:ListItem>
                <asp:ListItem Value="GPB">Pound Sterlin</asp:ListItem>
                <asp:ListItem Value ="AUD">Australian Dollar</asp:ListItem>
                <asp:ListItem Value="JPY">Japanese Yen</asp:ListItem>
                <asp:ListItem Value="CAD">Canadian Dollar</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged2"></asp:TextBox>
        </p>
        <p class="lead">
            TO:</p>
        <p class="lead">
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Value="USD">United States Dollar</asp:ListItem>
                <asp:ListItem Value="GPB">Pound Sterlin</asp:ListItem>
                <asp:ListItem Value ="AUD">Australian Dollar</asp:ListItem>
                <asp:ListItem Value="JPY">Japanese Yen</asp:ListItem>
                <asp:ListItem Value="CAD">Canadian Dollar</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Convert" />
        </p>
        <p class="lead">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
    </div>
</asp:Content>
