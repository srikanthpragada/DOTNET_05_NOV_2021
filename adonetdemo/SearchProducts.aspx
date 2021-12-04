<%@ Page Title="Search Products" Language="C#" MasterPageFile="~/Products.Master" AutoEventWireup="true" CodeBehind="SearchProducts.aspx.cs" Inherits="adonetdemo.SearchProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Search Products</h2>
    Product Name : <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    <p></p>
    <asp:DataList ID="dlProducts" runat="server">
        <ItemTemplate>
            <div class="item">
                <h3><%# Eval("prodname")%></h3>
                <h4><%# Eval("price") %></h4>
                <h5><%# Eval("remarks") %></h5>
                <a href='ProductSales.aspx?prodid=<%# Eval("prodid") %>'>Sales Report</a>
            </div>
        </ItemTemplate>
     </asp:DataList>
</asp:Content>
