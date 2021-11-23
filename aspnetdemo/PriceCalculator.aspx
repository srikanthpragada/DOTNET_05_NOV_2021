<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PriceCalculator.aspx.cs" Inherits="aspnetdemo.PriceCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Price Calculator</h2>
        Price per Unit
        <br />
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <p></p>
        Quantity Purchased
        <br />
        <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>
        <p></p>
        <asp:CheckBox ID="chkDiscount" runat="server" />Discounted Product
        <p></p>
        Payment Mode : 
        <asp:RadioButton ID="rbLumsum" runat="server" 
            GroupName="pmode"  Checked="true"/>Lumsum

        <asp:RadioButton ID="rbInstallments" runat="server" GroupName="pmode" />Installments
        <p></p>
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
        <p></p>
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
