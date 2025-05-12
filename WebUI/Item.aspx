<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="WebUI.Item" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Items</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gvItems" runat="server" AutoGenerateColumns="true" />
    </form>
</body>
</html>

