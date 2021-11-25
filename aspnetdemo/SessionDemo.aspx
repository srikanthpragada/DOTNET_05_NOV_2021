<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionDemo.aspx.cs"  Trace="true"
    Inherits ="aspnetdemo.SessionDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Language : <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <p></p>
        <asp:Button ID="btnAdd" runat="server" Text="Add Language" OnClick="btnAdd_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        <p></p>
        <asp:Label ID="lblLanguages" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
