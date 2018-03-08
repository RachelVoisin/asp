<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="Customers.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers</title>
    <link href="styles/formPanels.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="MainPanel" CssClass="Panels" runat="server">

                <asp:Label ID="lblCustomerNumber" CssClass="Labels" style="top:20px" runat="server" Text="Customer #"></asp:Label>
                <asp:TextBox ID="txtCustomerNumber" CssClass="TextBoxes" style="top:20px; width:111px; color:red" runat="server"></asp:TextBox>

                <asp:Label ID="lblFirstName" CssClass="Labels" style="top:50px" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox ID="txtFirstName" CssClass="TextBoxes" style="top:50px;" runat="server"></asp:TextBox>

                <asp:Label ID="lblLastName" CssClass="Labels" style="top:80px" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox ID="txtLastName" CssClass="TextBoxes" style="top:80px;" runat="server"></asp:TextBox>

                <asp:Label ID="lblAddress" CssClass="Labels" style="top:110px" runat="server" Text="Address"></asp:Label>
                <asp:TextBox ID="txtAddress" CssClass="TextBoxes" style="top:110px;" runat="server"></asp:TextBox>

                <asp:Label ID="lblCity" CssClass="Labels" style="top:140px" runat="server" Text="City"></asp:Label>
                <asp:TextBox ID="txtCity" CssClass="TextBoxes" style="top:140px; width:120px" runat="server"></asp:TextBox>

                <asp:Label ID="lblProvince" CssClass="Labels" style="top:170px" runat="server" Text="Province"></asp:Label>
                <asp:TextBox ID="txtProvince" CssClass="TextBoxes" style="top:170px; width:100px" runat="server"></asp:TextBox>

                <asp:Label ID="lblPostal" CssClass="Labels" style="top:200px" runat="server" Text="Postal"></asp:Label>
                <asp:TextBox ID="txtPostal" CssClass="TextBoxes" style="top:200px; width:80px" runat="server"></asp:TextBox>

                <asp:Button ID="btnNewCustomer" CssClass="Buttons" style="left:10px;" runat="server" Text="New" ToolTip="Create new customer" OnClick="btnNewCustomer_Click" />
                <asp:Button ID="btnAddCustomer" CssClass="Buttons" style="left:70px;" runat="server" Text="Add" ToolTip="Add new customer" OnClick="btnAddCustomer_Click" />
                <asp:Button ID="btnUpdateCustomer" CssClass="Buttons" style="left:130px;" runat="server" Text="Update" ToolTip="Update customer" OnClick="btnUpdateCustomer_Click" />
                <asp:Button ID="btnDeleteCustomer" CssClass="Buttons" style="left:210px;" runat="server" Text="Delete" ToolTip="Delete customer" OnClick="btnDeleteCustomer_Click" />
                <asp:Button ID="btnFindCustomer" CssClass="Buttons" style="left:290px;" runat="server" Text="Find" ToolTip="Find customer" OnClick="btnFindCustomer_Click" />



            </asp:Panel>
        </div>
    </form>
</body>
</html>
