<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataControls.aspx.cs" Inherits="ASPNet_April_24.DataControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>DataList Example</h1>
            <hr />
            <div style="text-align: center">
                <asp:DataList ID="dlProducts" GridLines="Both" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" OnItemCommand="dlProducts_ItemCommand">
                    <ItemTemplate>
                        <div>
                            <asp:Image ID="Image1" Text='<%#Eval("image1") %>' ImageUrl='<%#"ImageHandler.ashx?ID="+Eval("ID") %>' Height="100" Width="100" runat="server" />
                        </div>
                        <%--<div>
                            <asp:Label  Text='<%#Eval("image1") %>' ID="lblImage1" runat="server"/>
                        </div>--%>
                        <div>
                            <asp:Label Text='<%#Eval("ProductName") %>' ID="lblProductName" runat="server" />
                        </div>
                        <div>
                            <asp:Label Text='<%#Eval("Price") %>' ID="lblPrice" runat="server" />
                        </div>
                        <div>
                            <asp:Button Text="Details" ID="btnDetails" runat="server" CommandName="Details" CommandArgument='<%#Eval("ID") %>' />
                            <asp:Button Text="Buy Now" ID="btnBuyNow" runat="server" CommandName="BuyNow" CommandArgument='<%#Eval("ID") %>' />
                        </div>
                    </ItemTemplate>
                </asp:DataList>

                <asp:Image ID="imgProductImage" runat="server" />
            </div>
        </div>
    </form>

</body>
</html>
