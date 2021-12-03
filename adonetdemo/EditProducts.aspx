<%@ Page Title="Edit Products" Language="C#" MasterPageFile="~/Products.Master" AutoEventWireup="true" CodeBehind="EditProducts.aspx.cs" Inherits="adonetdemo.EditProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Edit Products</h2>
    <asp:GridView runat="server" DataKeyNames="prodid" DataSourceID="sdsProducts" width="100%">
        <columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </columns>
    </asp:GridView>

    <asp:SqlDataSource ID="sdsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:msdbConnectionString %>"
        DeleteCommand="DELETE FROM [products] WHERE [prodid] = @prodid"
        SelectCommand="SELECT * FROM [products]"
        UpdateCommand="UPDATE [products] SET [prodname] = @prodname, [price] = @price, [qoh] = @qoh, [remarks] = @remarks, [catcode] = @catcode WHERE [prodid] = @prodid">
        <deleteparameters>
            <asp:Parameter Name="prodid" Type="Int32" />
        </deleteparameters>

        <updateparameters>
            <asp:Parameter Name="prodname" Type="String" />
            <asp:Parameter Name="price" Type="Decimal" />
            <asp:Parameter Name="qoh" Type="Int32" />
            <asp:Parameter Name="remarks" Type="String" />
            <asp:Parameter Name="catcode" Type="String" />
            <asp:Parameter Name="prodid" Type="Int32" />
        </updateparameters>
    </asp:SqlDataSource>


</asp:Content>
