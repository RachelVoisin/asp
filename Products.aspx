<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Rachel_eCommerce.Products" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <link href="styles/formPanels.css" rel="stylesheet" />
        <link href="styles/ProductsStyle.css" rel="stylesheet" />

    </head>
    <body>
        <form id="form1" runat="server">
        <div>
            <asp:Panel ID="mainProductsPanel" CssClass="Panels" runat="server">

                <asp:Label ID="lblProductID" CssClass="Labels" style="top:20px" runat="server" Text="Product ID"></asp:Label>
                <asp:TextBox ID="txtProductID" CssClass="TextBoxes" style="top:20px" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="lblManCode" CssClass="Labels" style="top:50px" runat="server" Text="Manufacturer Code"></asp:Label>
                <asp:TextBox ID="txtManCode" CssClass="TextBoxes" style="top:50px" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="lblDescription" CssClass="Labels" style="top:80px" runat="server" Text="Description"></asp:Label>
                <asp:TextBox ID="txtDescription" CssClass="TextBoxes" style="top:80px" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="lblPicture" CssClass="Labels" style="top:110px" runat="server" Text="Picture"></asp:Label>
                <asp:TextBox ID="txtPicture" CssClass="TextBoxes" style="top:110px" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="lblQty" CssClass="Labels" style="top:140px" runat="server" Text="Quantity on Hand"></asp:Label>
                <asp:TextBox ID="txtQty" CssClass="TextBoxes" style="top:140px" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="lblPrice" CssClass="Labels" style="top:170px" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="txtPrice" CssClass="TextBoxes" style="top:170px" runat="server"></asp:TextBox>
                <br />

                <asp:Button ID="btnNew" CssClass="Buttons" style="left:10px;" runat="server" Text="New" OnClick="btnNew_Click" />
                <asp:Button ID="btnAdd" CssClass="Buttons" style="left:70px;" runat="server" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnUpdate" CssClass="Buttons" style="left:130px;" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" CssClass="Buttons" style="left:210px;" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                <asp:Button ID="btnFind" CssClass="Buttons" style="left:290px;" runat="server" Text="Find" OnClick="btnFind_Click" />
                <br />

                <asp:ListBox ID="listPictures" runat="server" OnSelectedIndexChanged="listPictures_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                
                <asp:Image ID="imgPictures" runat="server" />

            </asp:Panel>
        </div>
    </form>
</body>
</html>
