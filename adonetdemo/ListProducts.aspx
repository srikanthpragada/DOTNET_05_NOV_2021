<%@ Page Title="List Products" Language="C#" MasterPageFile="~/Products.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="adonetdemo.ListProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Product</h2>
    <asp:GridView ID="gvProducts" AutoGenerateColumns="False" DataSourceID="sdsProducts" runat="server" Width="100%" AllowPaging="True" PageSize="5">
        <Columns>
            <asp:BoundField DataField="prodid" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="prodid" />
            <asp:BoundField DataField="prodname" HeaderText="Name" SortExpression="prodname" />
            <asp:BoundField DataField="price" DataFormatString="{0:######.00}" HeaderText="Price" SortExpression="price">
                <ItemStyle HorizontalAlign="Right" />   
            </asp:BoundField>

            <asp:BoundField DataField="qoh" HeaderText="Qoh" SortExpression="qoh">
                <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>

            <asp:BoundField DataField="catcode" HeaderText="catcode" SortExpression="catcode">
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>


    </asp:GridView>

    <asp:SqlDataSource ID="sdsProducts" runat="server"
        ConnectionString="<%$ ConnectionStrings:msdbConnectionString %>"
        SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>

</asp:Content>
