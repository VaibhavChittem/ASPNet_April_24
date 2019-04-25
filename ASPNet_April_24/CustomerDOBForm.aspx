<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="CustomerDOBForm.aspx.cs" Inherits="ASPNet_April_24.CustomerDOBForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <label>From Date</label>
                </td>
                <td>
                    <asp:TextBox ID="txtFromDate" runat="server" TextMode="Date"></asp:TextBox>

                </td>

                <td>
                    <label>ToDate</label>
                </td>
                <td>
                    <asp:TextBox ID="txtToDate" runat="server" TextMode="Date"></asp:TextBox>
                </td>

            </tr>
        </table>
        <asp:Button ID="txtSearch" runat="server" Text="Search" OnClick="txtSearch_Click" />
        <asp:GridView ID="gvSearch" runat="server"></asp:GridView>
    </form>
    
</body>
</html>
