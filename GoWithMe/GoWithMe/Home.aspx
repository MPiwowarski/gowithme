<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GoWithMe.Home" %>

<%@ Register Src="~/UserControls/SearchForm/ControlTemplates/GoWithMe.SearchForm/SearchForm_SearchEngine.ascx" TagPrefix="uc1" TagName="SearchForm_SearchEngine" %>



<%--copy "$(SolutionDir)\WebApplication1\*.ascx" "$(ProjectDir)\UserControls\"--%>
<%--xcopy "$(SolutionDir)\GoWithMe.SearchForm\*" "$(ProjectDir)\UserControls\SearchForm" /e--%>

<%--LINK DO ARTYKULU JAK DODAWAC DO PROJEKTOW .ascx z innego projetku:--%>
<%--http://webproject.scottgu.com/CSharp/usercontrols/usercontrols.aspx--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />   
    <link href="css/Home.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />   
    <link href="jQueryFiles/jquery-ui-1.8.16.custom.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
   
    <script type="text/javascript" src="jQueryFiles/jquery-1.6.4.min.js"></script>
    <script type="text/javascript" src="jQueryFiles/jquery-ui-1.8.16.custom.min.js"></script>
    <script type="text/javascript" src="Scripts/HomeCalendar.js"></script>
    <script src="Scripts/OfferYourRideButton.js"></script>

    <style type="text/css">
        .txtBoxDateRide {
            background-image: url("~/Images/Calendar.jpg");
            background-repeat: no-repeat;
            background-position: left center;
        }
    </style>
    
    
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
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
                    <li><a href="LoginPanel.aspx">Zaloguj się</a></li>
                    <li>/</li>
                    <li><a href="#">Kontakt</a></li>
                    <li>/</li>
                    <li><a href="#">Pomoc</a></li>
                </ul>
            </div>

            <div id="overview" style="">
                <h1 style="float: left">Znajdź przejazd!</h1>
                <asp:Button ID="offerRide" runat="server" Text="Sam zaoferuj przejazd!" Style="float: right" OnClick="offerRide_Click" />
                
                <uc1:SearchForm_SearchEngine runat="server" ID="SearchForm_SearchEngine" />
            </div>



            <div id="main">

                <div class="left">
                    <h3>Zobacz sam!</h3>
                    <img src="img/tapeta3.png" id="banner" />
                    <p><a href="#" class="btn">Zobacz więcej &raquo;</a></p>
                </div>
         
                <div class="right">
                   
                    <h3>Jesteśmy po to by ułatwić Ci życie!</h3>
                    <p>
                        Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.
               Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante fusce non varius purus aenean nec magna felis fusce vestibulum velit mollis odio sollicitudin lacinia aliquam posuere, sapien elementum lobortis tincidunt, turpis dui ornare nisl, sollicitudin interdum turpis nunc eget.
                    Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.
                    </p>
                    <p><a href="#" class="btn">Zobacz więcej &raquo;</a></p>
                </div>
                <br class="clearit" />

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
