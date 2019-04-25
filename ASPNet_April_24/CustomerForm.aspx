<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerForm.aspx.cs" Inherits="ASPNet_April_24.CustomerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <label>First Name</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Last Name</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtlastName" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Email Id</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmailID" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label>Password</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
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
            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
