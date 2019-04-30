<%@ Page Title="" Language="C#" MasterPageFile="~/OnlineShopping.Master" AutoEventWireup="true" CodeBehind="OrderDetailChildPage.aspx.cs" Inherits="ASPNet_April_24.OrderDetailChildPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="OrderDetail" ContentPlaceHolderID="OrderDetailContentPlaceHolder" runat="server">
    <table align="center">
        <tr>
            <td>
                <label>Order ID</label></td>
            <td>
                <asp:Label ID="lblOrderID" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>
                <label>Product ID</label></td>
            <td>
                <asp:Label ID="lblProductID" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>
                <label>Customer ID</label></td>
            <td>
                <asp:Label ID="lblCustomerID" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>
                <label>Total Price</label></td>
            <td>
                <asp:Label ID="lblTotalPrice" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Total Quantity</td>
            <td>
                <asp:DropDownList ID="ddlDropDownList" runat="server" OnSelectedIndexChanged="ddlDropDownList_SelectedIndexChanged">
                    <asp:ListItem Text="Select" />
                    <asp:ListItem Text="1" />
                    <asp:ListItem Text="2" />
                    <asp:ListItem Text="3" />
                    <asp:ListItem Text="4" />
                    <asp:ListItem Text="5" />
                    <asp:ListItem Text="6" />
                    <asp:ListItem Text="7" />
                    <asp:ListItem Text="8" />
                    <asp:ListItem Text="9" />
                    <asp:ListItem Text="10" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Order Date</td>
            <td><asp:Label ID="lblOrderDate" runat="server"  Text="" ></asp:Label><br /></td>
            
        </tr>
    </table>
    <div align="center">
        <asp:Button ID="btnSave" runat="server" Text="Place Order" />
    </div>
</asp:Content>
