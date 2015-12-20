<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUserImage.aspx.cs" Inherits="GoWithMe.AddUserImage" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Src="~/UserControls/SearchForm/ControlTemplates/GoWithMe.SearchForm/SearchForm_SearchEngine.ascx" TagPrefix="uc1" TagName="SearchForm_SearchEngine" %>
<%@ Register Src="~/UserControls/UserPanelMenu/ControlTemplates/GoWithMe.UserPanelMenu/UserPanelMenu_Menu.ascx" TagPrefix="uc1" TagName="UserPanelMenu_Menu" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <link href="css/AddUserImage.css" rel="stylesheet" />
    <link href="jQueryFiles/jquery-ui-1.8.16.custom.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />

    <script type="text/javascript" src="jQueryFiles/jquery-1.6.4.min.js"></script>
    <script type="text/javascript" src="jQueryFiles/jquery-ui-1.8.16.custom.min.js"></script>

    <title>Panel urzytkownika</title>
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
                    <uc1:UserPanelMenu_Menu runat="server" ID="UserPanelMenu_Menu" />
                    <div id="addImagePanel">

                        <div id="uploadImgPanel">
                            <p>
                                Dodaj tutaj swoje zdjęcie profilowe! Dzięki temu inni użytkownicy zobaczą, z kim będą podróżować, 
                              a Ty łatwiej znajdziesz współpasażerów. Poza tym zdjęcia pomagają się wzajemnie rozpoznać na początku podróży. 
                            </p>
                            <table>
                                <tr>
                                    <td>
                                        <asp:FileUpload ID="LoadUserImageControl" runat="server" />
                                    </td>

                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="SaveImageControl" runat="server" Text="Zapisz zdjęcie" OnClick="SaveImageControl_Click" />
                                    </td>
                                    <td>
                                        <asp:Label ID="StatusLabelControl" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            <img src="Images/AddUserImage/ZasadyZamieszczaniaZdjec.bmp" />
                        </div>
                        <div id="actuallImage">
                            <h4>Twoje aktualne zdjęcie:</h4>
                            <asp:Image ID="ActualUserImage" runat="server" CssClass="actualImg"/>
                        </div>
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
