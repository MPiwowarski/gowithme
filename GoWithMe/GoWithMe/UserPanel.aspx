<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPanel.aspx.cs" Inherits="GoWithMe.UserPanel" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Src="~/UserControls/SearchForm/ControlTemplates/GoWithMe.SearchForm/SearchForm_SearchEngine.ascx" TagPrefix="uc1" TagName="SearchForm_SearchEngine" %>
<%@ Register Src="~/UserControls/UserPanelMenu/ControlTemplates/GoWithMe.UserPanelMenu/UserPanelMenu_Menu.ascx" TagPrefix="uc1" TagName="UserPanelMenu_Menu" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <link href="css/UserPanel.css" rel="stylesheet" />
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
                <uc1:SearchForm_SearchEngine runat="server" id="SearchForm_SearchEngine" />

                <div id="main">
                    <div id="userPanel">

                        <uc1:UserPanelMenu_Menu runat="server" ID="UserPanelMenu_Menu" />


                        <div id="userDataPanel" style="float:left;">
                            <table>
                                <tr>
                                    <td colspan="2">
                                        <h2>Dane użytkownika</h2>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="UserDataLabels">Email</label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="emailControl" runat="server" CssClass="userPanelFields">
                                        </asp:TextBox>
                                  
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="UserDataLabels">Login </label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="loginControl" runat="server" CssClass="userPanelFields">
                                        </asp:TextBox>
                                  
                                    </td>
                                </tr>


                                <tr style="border-top: solid black 3px">
                                    <td>
                                        <label class="UserDataLabels">Imię </label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="nameControl" runat="server" CssClass="userPanelFields">
                                        </asp:TextBox>
                                      
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <label class="UserDataLabels">Nazwisko </label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="surnameControl" runat="server" CssClass="userPanelFields">
                                        </asp:TextBox>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="UserDataLabels">Hasło</label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="passwordControl" runat="server" CssClass="userPanelFields"
                                            TextMode="Password">

                                        </asp:TextBox>
                                     
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="UserDataLabels">Potwierdź hasło</label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="confirmPasswordControl" runat="server" TextMode="Password"
                                            CssClass="userPanelFields"></asp:TextBox>                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="UserDataLabels">Numer telefonu </label>
                                    </td>
                                    <td>
                                        
                                        <div>
                                            <asp:TextBox ID="phoneNumberControl" runat="server" CssClass="userPanelFields"></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>

                                <tr>
                                    <td></td>
                                    <td colspan="2">
                                        <asp:Button ID="AcceptBtnControl" runat="server" Text="Zapisz zmiany" CssClass="AcceptButton" OnClick="AcceptBtnControl_Click" />

                                    </td>
                                </tr>
                             
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="statusControl" runat="server" Font-Bold="true"></asp:Label>
                                    </td>
                                </tr>



                            </table>
                        </div>

                        <div style="float:right;">
                            <img src="Images/UserPanel/UserPanelImage.png" />
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
