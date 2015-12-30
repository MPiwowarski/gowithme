<%@ Page Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GoWithMe.Home" %>

<%@ Register Src="~/UserControls/SearchForm/ControlTemplates/GoWithMe.SearchForm/SearchForm_SearchEngine.ascx" TagPrefix="uc1" TagName="SearchForm_SearchEngine" %>
<%@ Register Src="~/UserControls/MainMenu/ControlTemplates/GoWithMe.MainMenu/MainMenu_Menu.ascx" TagPrefix="uc1" TagName="MainMenu_Menu" %>

<asp:Content ID="Head" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/OfferYourRideButton.js"></script>
    <link href="css/Home.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <title>Home</title>
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="mainContent" runat="server">

    <div class="overview" style="">
        <h1 style="float: left">Find ride offert!</h1>
        <asp:Button ID="offerRide" runat="server" Text="Create your ride offert!" CssClass="offerRide" Style="float: right" OnClick="offerRide_Click" />

        <uc1:SearchForm_SearchEngine runat="server" ID="SearchForm_SearchEngine" />
    </div>

    <div class="main">

        <div class="left">
            <h3>Just see!</h3>
            <img src="img/tapeta3.png" id="banner" />
            <p><a href="#" class="btn">See more &raquo;</a></p>
        </div>

        <div class="right">

            <h3>We are here to make your life easier!</h3>
            <p>
                Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.
                Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante fusce non varius purus aenean nec magna felis fusce vestibulum velit mollis odio sollicitudin lacinia aliquam posuere, sapien elementum lobortis tincidunt, turpis dui ornare nisl, sollicitudin interdum turpis nunc eget.
                Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.
            </p>
            <p><a href="#" class="btn">See more &raquo;</a></p>
        </div>
        <br class="clearit" />

    </div>

</asp:Content>

