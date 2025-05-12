<%@ Page Title="Order Report" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderReport.aspx.cs" Inherits="WebUI.OrderReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Order Report</h2>

    <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False" Width="100%">
        <Columns>
            <asp:BoundField DataField="OrderID" HeaderText="Order ID" />
            <asp:BoundField DataField="OrderDate" HeaderText="Order Date" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="AgentName" HeaderText="Agent" />
            <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" DataFormatString="{0:C}" />
        </Columns>
    </asp:GridView>
</asp:Content>

