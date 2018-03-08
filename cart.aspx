<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="Rachel_eCommerce.cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cart</title>
    <link href="styles/fonts.css" rel="stylesheet" />
    <link href="styles/cartStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="Button" style="visibility:hidden" OnClick="RemoveFromCart_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="LblTotal" runat="server" CssClass="LabelTotal" Text="0.00"></asp:Label>
        <asp:Button ID="btnRecalculate" runat="server" Text="Recalculate Total" CssClass="btnSelect" OnClick="btnRecalculate_Click" />
        <asp:Label ID="lblRowSelected" runat="server" CssClass="Labels"></asp:Label>
    </form>

</body>
</html>
