<%@ Page Title="" Language="C#" MasterPageFile="~/OnlineShopping.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ASPNet_April_24.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="OrderDetailContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="LoginID" ContentPlaceHolderID="LoginPageContentPlaceHolder" runat="server">
    <table align="center">
        <tr>
            <%--<asp:Login ID="Login1" runat="server"></asp:Login>--%>
            <td>
                <label>Email</label></td>
            <td>
                <asp:TextBox ID="txtEmailID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <label>Password</label></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
        </tr>

    </table>
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="red"></asp:Label></td>
            </tr>
        </table>
    </div>

</asp:Content>
