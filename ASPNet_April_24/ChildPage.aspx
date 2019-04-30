<%@ Page Title="" Language="C#" MasterPageFile="~/OnlineShopping.Master" AutoEventWireup="true" CodeBehind="ChildPage.aspx.cs" Inherits="ASPNet_April_24.ChildPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>



