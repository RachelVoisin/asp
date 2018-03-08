<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="catalogue.aspx.cs" Inherits="Rachel_eCommerce.catalogue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Catalogue</title>
    <link href="styles/fonts.css" rel="stylesheet" />
    <link href="styles/catalogue.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">
        <asp:Table ID="Table1" runat="server"></asp:Table>
        <asp:Button ID="EventButton" runat="server" Text="Invisible" OnClick="AddToCart_Click" />
        <br />
        <br />
        <asp:Label ID="lblRowSelected" CssClass="labels" runat="server" Text="...select a button"></asp:Label>
    </form>
    
</body>
</html>
