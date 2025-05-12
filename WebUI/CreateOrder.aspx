<%@ Page Title="Create Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateOrder.aspx.cs" Inherits="WebUI.CreateOrder" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create Order</h2>

    <asp:DropDownList ID="ddlAgents" runat="server" />
    <br /><br />

    <asp:DropDownList ID="ddlItems" runat="server" />
    <asp:TextBox ID="txtQuantity" runat="server" Width="50px" Placeholder="Qty" />
    <asp:TextBox ID="txtUnitAmount" runat="server" Width="80px" Placeholder="Unit Price" />
    <asp:Button ID="btnAddItem" runat="server" Text="Add Item" OnClick="btnAddItem_Click" />
    <br /><br />

    <asp:GridView ID="gvOrderDetails" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ItemID" HeaderText="Item ID" />
            <asp:BoundField DataField="ItemName" HeaderText="Item Name" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="UnitAmount" HeaderText="Unit Price" />
        </Columns>
    </asp:GridView>
    <br />

    <asp:Button ID="btnSubmitOrder" runat="server" Text="Submit Order" OnClick="btnSubmitOrder_Click" />
    <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />
</asp:Content>

