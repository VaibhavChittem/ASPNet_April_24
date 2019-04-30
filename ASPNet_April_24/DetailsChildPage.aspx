<%@ Page Title="" Language="C#" MasterPageFile="~/OnlineShopping.Master" AutoEventWireup="true" CodeBehind="DetailsChildPage.aspx.cs" Inherits="ASPNet_April_24.DetailsChildPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="OrderDetailContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CustomerFormContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="LoginPageContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Details" ContentPlaceHolderID="DetailsContentPlaceHolder" runat="server">
    <div align="center">
        <div>
            <asp:Image ID="imgDetails" runat="server" Height="200" Width="200" />
        </div>
        <div>
            <label>Product Name :</label>
            <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <label>Category :</label>
            <asp:Label ID="lblCategory" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <label>Price :</label>
            <asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
</asp:Content>
