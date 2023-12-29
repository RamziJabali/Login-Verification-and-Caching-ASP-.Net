<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginRegisterForm.aspx.cs" Inherits="_445_Project_5.LoginRegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
</head>
<body>
    <form id="loginForm" runat="server">
        <h1>Login or Register</h1>

    <table>
    <tr>
        <td>UserName:</td>
        <td><input id="txtUserName" type="text" runat="server"/></td>
        <td><ASP:RequiredFieldValidator ControlToValidate="txtUserName"
            Display="Static" ErrorMessage="*" runat="server" 
            ID="vUserName" /></td>
    </tr>
    <tr>
        <td>Password:</td>
        <td><input id="txtUserPass" type="password" runat="server"/></td>
        <td><ASP:RequiredFieldValidator ControlToValidate="txtUserPass"
        Display="Static" ErrorMessage="*" runat="server"
        ID="vUserPass" />
        </td>
    </tr>
        <tr>
        <td><asp:Button ID="Login_Button" runat="server" Text="Login" OnClick="Login_Button_Click"/></td>
        <td><asp:Button ID="Register_Button" runat="server" Text="Register" OnClick="Register_Button_Click"/></td>
        <td></td>
    </tr>
    <tr>
        <td>Persistent Cookie:</td>
        <td><ASP:CheckBox id="chkPersistCookie" runat="server" autopostback="false" /></td>
        <td></td>
    </tr>
</table>
</form>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
</body>
</html>
