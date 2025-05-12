<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebUI.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 50px;">
            <h2>Login</h2>
            <asp:Label runat="server" Text="Username:" AssociatedControlID="txtUsername" />
            <asp:TextBox runat="server" ID="txtUsername" /><br /><br />
            <asp:Label runat="server" Text="Password:" AssociatedControlID="txtPassword" />
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" /><br /><br />
            <asp:Button runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click" /><br /><br />
            <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
        </div>
    </form>
</body>
</html>


