<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="ASPNet_April_24.Header" %>
<%@ OutputCache Duration="10" VaryByParam="none" %>
<link href="Content/bootstrap.css" rel="stylesheet" />

<div class="container">
    <div class="row">
        <div class="col-md-5">
            <img src="Image/myntra-logo.jpg" height="250" width="250" />
        </div>

        <div class="col-md-5">
            <br />
            <br />
            <br />
            <br />
            <br />
            <h4>Myntra----Online Store</h4>
        </div>
        <div class="col-md-2">
            <asp:Button ID="btnSignIn" runat="server" Text="SignIn" OnClick="btnSignIn_Click" />
        </div>
    </div>
</div>
<ul class="nav nav-pills">
    <li class="nav-item">
        <a class="nav-link " href="ChildPage.aspx">Home</a>
    </li>
    <li class="nav-item">
        <a class="nav-link " href="#">MEN</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#">WOMEN</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#">KIDS</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#">HOME&LIVING</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#">DISCOVER</a>
    </li>



</ul>


