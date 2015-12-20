<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OffertsPanel.aspx.cs" Inherits="GoWithMe.OffertsPanel" %>

<%@ Register Src="~/UserControls/SearchForm/ControlTemplates/GoWithMe.SearchForm/SearchForm_SearchEngine.ascx" TagPrefix="uc1" TagName="SearchForm_SearchEngine" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="css/style.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <link href="css/OffertsPanel.css" rel="stylesheet" />
    <link href="jQueryFiles/jquery-ui-1.8.16.custom.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />

    <script type="text/javascript" src="jQueryFiles/jquery-1.6.4.min.js"></script>
    <script type="text/javascript" src="jQueryFiles/jquery-ui-1.8.16.custom.min.js"></script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="wrapper">

                <div id="logo">
                    <h1>Go With Me
                    </h1>
                </div>

                <div id="nav">
                    <ul>
                        <li><a href="Home.aspx">Home</a></li>
                        <li>/</li>
                        <li><a href="Registration.aspx">Rejestracja</a></li>
                        <li>/</li>
                        <li><a href="#">Kontakt</a></li>
                        <li>/</li>
                        <li><a href="#">Pomoc</a></li>
                    </ul>          

                </div>
                <uc1:SearchForm_SearchEngine runat="server" ID="SearchForm_SearchEngine" />

                <div id="main">
                    <div id="searchResult" runat="server">
                        
                    </div>
              
                </div>
            </div>

        </div>

        <div id="footer">
            <ul>
                <li><a href="#">Najtańsze przejazdy</a></li>
                <li>/</li>
                <li><a href="#">Newsy</a></li>
                <li>/</li>
                <li><a href="#">FAQ</a></li>
                <li>/</li>
                <li><a href="#">Mapa strony</a></li>
            </ul>
        </div>

       
    </form>
</body>
</html>
