<%@ Page Theme="BlueTheme" Language="C#" AutoEventWireup="true" CodeBehind="ProductForm.aspx.cs" Inherits="ASPNet_April_24.ProductForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap-grid.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="align-content-center">
                <tr >
                    <td>
                        <label>Product Name</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                    </td>
                    

                </tr>
                <tr>
                    <td>
                        <label>Category</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlCategory">
                            <asp:ListItem Text="HomeWare" />
                            <asp:ListItem Text="Kitchenware" />
                            <asp:ListItem Text="Clothing" />
                            <asp:ListItem Text="Accessories" />
                            <asp:ListItem Text="Electronics" />
                        </asp:DropDownList>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Description</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Price</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Quantity</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Image</label>
                    </td>
                    <td>
                        <asp:FileUpload ID="fuImage" runat="server" />
                    </td>

                </tr>
            </table>
        </div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

        <asp:Label ID="lblImage" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
