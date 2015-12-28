<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPanel.aspx.cs" Inherits="GoWithMe.LoginPanel" %>

<%@ Register Src="~/UserControls/MainMenu/ControlTemplates/GoWithMe.MainMenu/MainMenu_Menu.ascx" TagPrefix="uc1" TagName="MainMenu_Menu" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <link href="css/LoginPanel.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />

    <link href="jQueryFiles/jquery-ui-1.8.16.custom.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />



    <script type="text/javascript" src="jQueryFiles/jquery-1.6.4.min.js"></script>
    <script type="text/javascript" src="jQueryFiles/jquery-ui-1.8.16.custom.min.js"></script>

    <title>Login Panel</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="wrapper">

                <div id="logo">
                    <h1>Go With Me
                    </h1>
                </div>

                <uc1:MainMenu_Menu runat="server" ID="MainMenu_Menu" />



                <div id="main">

                    <div id="loginPanel">
                        <div id="LoginFormHeader">
                            <p>Login to your account</p>
                        </div>
                        <div id="loginForm">
                            <img id="headIconPicture" src="Images/LoginPanel/HeadIcon.jpg" />
                            <table class="loginFormTable">
                                <tr>
                                    <td>
                                        <asp:Label ID="LoginTryLbl" runat="server" Text="Login:" CssClass="LoginTryLbl"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="LoginTryControl" runat="server" CssClass="LoginTryControl"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="PasswordTryLbl" runat="server" Text="Password:" CssClass="PasswordTryLbl"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="PasswordTryControl" TextMode="Password" runat="server" CssClass="PasswordTryControl"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>

                                    <td>
                                        <asp:Button ID="LoginBtnControl" OnClick="LoginBtnControl_Click" runat="server" Text="Login" CssClass="loginFormButton" />
                                    </td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>
                                        <a href="HelpdeskLogin.aspx">Do you need help?</a>
                                    </td>
                                    <td>
                                        <asp:Label ID="LoginResultInfoLblControl" runat="server" Text=""></asp:Label>
                                    </td>

                                </tr>
                                <tr>

                                    <td>
                                        <asp:Label ID="ResultTryLogin" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div id="footerLoginForm">
                            <a href="Registration.aspx">You don't have account yet? Register!</a>
                        </div>
                    </div>
                </div>

            </div>


        </div>
    </form>
</body>
</html>
