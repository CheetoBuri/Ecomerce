<%@ Page Title="Add Item" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="WebUI.AddItem" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add Item</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Green" /><br />

    <asp:TextBox ID="txtItemName" runat="server" Placeholder="Item Name" /><br /><br />
    <asp:TextBox ID="txtSize" runat="server" Placeholder="Size" /><br /><br />
    <asp:Button ID="btnAdd" runat="server" Text="Add Item" OnClick="btnAdd_Click" />

</asp:Content>


