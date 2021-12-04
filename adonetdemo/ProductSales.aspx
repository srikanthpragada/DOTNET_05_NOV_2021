<%@ Page Title="Sales Report" Language="C#" MasterPageFile="~/Products.Master" AutoEventWireup="true" CodeBehind="ProductSales.aspx.cs" Inherits="adonetdemo.ProductSales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Sales Report</h2>
    <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" DataKeyNames="invno" DataSourceID="sdsSales" EmptyDataText="Sorry! No sales information found!">
        <Columns>
            <asp:BoundField DataField="invno" HeaderText="invno" InsertVisible="False" ReadOnly="True" SortExpression="invno" />
            <asp:BoundField DataField="prodid" HeaderText="prodid" SortExpression="prodid" />
            <asp:BoundField DataField="transdate" HeaderText="transdate" SortExpression="transdate" />
            <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
            <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sdsSales" runat="server" ConnectionString="<%$ ConnectionStrings:msdbConnectionString %>" SelectCommand="SELECT * FROM [sales] WHERE ([prodid] = @prodid)">
        <SelectParameters>
            <asp:QueryStringParameter Name="prodid" QueryStringField="prodid" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
