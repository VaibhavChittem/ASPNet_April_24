<%@ Page Title="" Language="C#" MasterPageFile="~/OnlineShopping.Master" AutoEventWireup="true" CodeBehind="RegistrationChildPage.aspx.cs" Inherits="ASPNet_April_24.RegistrationChildPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="OrderDetailContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CustomerFormContentPlaceHolder" runat="server">
      <div align="center">
            <table>
                <tr>
                    <td>
                        <label>First Name</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="Field should not be empty" ForeColor="Red" ControlToValidate="txtFirstName"  runat="server" />
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Last Name</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtlastName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="Field should not be empty" ForeColor="Red" ControlToValidate="txtlastName" runat="server" />
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Email Id</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmailID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="Field should not be empty" ForeColor="Red" ControlToValidate="txtEmailID" runat="server" />
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Password</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="Field should not be empty" ForeColor="Red" ControlToValidate="txtPassword" runat="server" />
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Date Of Birth</label>
                    </td>
                    <td>
                        <asp:TextBox ID="dtDOB" runat="server" TextMode="Date"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Mobile No</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMobileNo" runat="server" TextMode="Phone"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="Field should not be empty" ForeColor="Red" ControlToValidate="txtMobileNo" runat="server" />
                        <asp:RegularExpressionValidator ErrorMessage="Email should be of proper format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtMobileNo" runat="server" />

                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Address</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnSumbit" runat="server" Text="Submit" OnClick="btnSumbit_Click" />
            <br /><br />
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
        </div>
        <div>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="LoginPageContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="head" runat="server">
</asp:Content>
