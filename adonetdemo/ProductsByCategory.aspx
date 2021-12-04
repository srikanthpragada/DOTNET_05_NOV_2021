<%@ Page Title="" Language="C#" MasterPageFile="~/Products.Master" AutoEventWireup="true" CodeBehind="ProductsByCategory.aspx.cs" Inherits="adonetdemo.ProductsByCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Products by Category</h2>
    Select Category :
    <asp:DropDownList ID="ddlCategories" runat="server" AutoPostBack="True" DataSourceID="sdsCategories" DataTextField="catdesc" DataValueField="catcode"></asp:DropDownList>
    <asp:SqlDataSource ID="sdsCategories" runat="server" ConnectionString="<%$ ConnectionStrings:msdbConnectionString %>" SelectCommand="SELECT * FROM [categories] ORDER BY [catdesc]"></asp:SqlDataSource>
    <p></p>
    <asp:GridView ID="gvProducts" runat="server" Width ="100%" AutoGenerateColumns="False" DataKeyNames="prodid" DataSourceID="sdsProducts" EmptyDataText="Sorry! No products found.">
        <Columns>
            <asp:BoundField DataField="prodid" HeaderText="prodid" InsertVisible="False" ReadOnly="True" SortExpression="prodid" />
            <asp:BoundField DataField="prodname" HeaderText="prodname" SortExpression="prodname" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="qoh" HeaderText="qoh" SortExpression="qoh" />
            <asp:BoundField DataField="remarks" HeaderText="remarks" SortExpression="remarks" />
        </Columns>
        <EmptyDataRowStyle Font-Bold="True" Font-Size="14pt" ForeColor="#FF3300" />
    </asp:GridView>
    <asp:SqlDataSource ID="sdsProducts" runat="server" 
        ConnectionString="<%$ ConnectionStrings:msdbConnectionString %>" 
        SelectCommand="SELECT [prodid], [prodname], [price], [qoh], [remarks] FROM [products] WHERE ([catcode] = @catcode)">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlCategories" Name="catcode" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
