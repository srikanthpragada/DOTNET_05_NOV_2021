<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hello.aspx.cs" Inherits="aspnetdemo.hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
</head>
<body>
    <h2>Welcome</h2>
    <form id="form1" runat="server">
        Name 
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <p></p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <p></p>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

    </form>
</body>
</html>
