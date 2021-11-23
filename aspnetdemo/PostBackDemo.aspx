<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBackDemo.aspx.cs" Inherits="aspnetdemo.PostBackDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Postback Demo</h1>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        <p></p>
        Courses : 
        <asp:DropDownList ID="ddlCourses" runat="server" AutoPostBack="true">
            <asp:ListItem Value="48">Microsoft.NET</asp:ListItem>
            <asp:ListItem Value="36">Python</asp:ListItem>
            <asp:ListItem Value="40">Java EE</asp:ListItem>
        </asp:DropDownList>
        <p></p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit"  />
    </form>
</body>
</html>
