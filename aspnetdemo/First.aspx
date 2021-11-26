<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="aspnetdemo.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnRedirect" runat="server" Text="Redirect" OnClick="btnRedirect_Click" />
        <p></p>
        <asp:Button ID="btnTransfer" runat="server"   Text="Tranfer" OnClick="btnTransfer_Click" />
        <p></p>
        <asp:Button ID="btnExecute" runat="server" Text="Execute" OnClick="btnExecute_Click" />
    </form>
</body>
</html>
