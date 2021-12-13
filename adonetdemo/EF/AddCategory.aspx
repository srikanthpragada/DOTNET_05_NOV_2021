<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="adonetdemo.EF.AddCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Add Category</h2>
        Code : <asp:TextBox ID="txtCode" runat="server"></asp:TextBox> <br />
        Description : <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox> 
        <p></p>
        <asp:Button ID="btnAdd" runat="server" Text="Add Category" OnClick="btnAdd_Click" />

    </form>
</body>
</html>
