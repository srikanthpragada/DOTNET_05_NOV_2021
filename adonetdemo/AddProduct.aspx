<%@ Page Title="Add Product" Language="C#" MasterPageFile="~/Products.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="adonetdemo.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Add Product</h2>
    Product Name <br />
    <asp:TextBox id="txtName" runat="server" Required="true"></asp:TextBox>
    <p></p>
     Product Price <br />
    <asp:TextBox id="txtPrice" runat="server" TextMode="Number" Required="true" ></asp:TextBox>
    <p></p>
     Quantity on hand <br />
    <asp:TextBox id="txtQoh" runat="server" TextMode="Number" Required="true"></asp:TextBox>
    <p></p>
     Category Code<br />
    <asp:TextBox id="txtCategoryCode" runat="server" Required="true"></asp:TextBox>
    <p></p>
    Remarks<br />
    <asp:TextBox id="txtRemarks" runat="server"></asp:TextBox>
    <p></p>
    <asp:Button runat="server" Text="Add Product" id="btnAdd" OnClick="btnAdd_Click" />
    <p></p>
    <asp:Label runat="server" id="lblMsg" Text=""></asp:Label>
</asp:Content>
