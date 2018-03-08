<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Rachel_eCommerce.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rachel_eCommerce</title>
    <link href="styles/defaultStyle.css" rel="stylesheet" />
    <link href="styles/fonts.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <header>
            <img src="images/pusheen-comp.jpg" />
            <h1>LaSquish Imports Online</h1>
        </header>

        <div id="webControlPanel">
            <asp:Button ID="btnPromoPage" class="btn" runat="server" Text="Promo Page" OnClick="btnPromoPage_Click" />
            <asp:Button ID="btnCatalog" class="btn" runat="server" Text="Catalog" OnClick="btnCatalog_Click" />
            <asp:Button ID="btnCart" class="btn" runat="server" Text="Cart" OnClick="btnCart_Click" />
            <asp:Button ID="btnCustomers" class="btn" runat="server" Text="Customers" OnClick="btnCustomers_Click" />
            <asp:Button ID="btnProducts" class="btn" runat="server" Text="Products" OnClick="btnProducts_Click" />
            <span id="span1">Admin Only!</span>
            <span id="span2">Admin Only!</span>
        </div>

        <iframe ID="myFrame" runat="server" src="catalogue.aspx" height="1000">
            <p>your browser does not support iframes</p>
        </iframe>



    </form>
</body>
</html>
