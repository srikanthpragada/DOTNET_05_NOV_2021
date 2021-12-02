<%@ Page Title="List Products" Language="C#" MasterPageFile="~/Products.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="adonetdemo.ListProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Product</h2>
    <asp:GridView  id="gvProducts" DataSourceId="sdsProducts" runat="server" Width="100%"></asp:GridView>

    <asp:SqlDataSource id="sdsProducts" runat="server" 
        ConnectionString="<%$ ConnectionStrings:msdbConnectionString %>" 
        SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>

</asp:Content>
