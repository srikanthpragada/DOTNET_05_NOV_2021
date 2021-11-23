<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadPhotos.aspx.cs" Inherits="aspnetdemo.UploadPhotos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h2>Upload Photos</h2>
         Photo : <asp:FileUpload ID="FileUpload1" runat="server" />
         <p></p>
         <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
         <p></p>
            
         <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
