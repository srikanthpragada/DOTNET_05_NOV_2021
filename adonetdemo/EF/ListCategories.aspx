<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListCategories.aspx.cs" Inherits="adonetdemo.EF.ListCategories" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Categories</title>
</head>
<body>
    <form id="form1" runat="server">
         <h2>Categories</h2>
         <asp:GridView ID="gvCategories" runat="server"></asp:GridView>
    </form>
</body>
</html>
