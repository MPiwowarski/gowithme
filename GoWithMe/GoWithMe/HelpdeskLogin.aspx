<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelpdeskLogin.aspx.cs" Inherits="GoWithMe.HelpdeskLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <link href="css/HelpdeskPanel.css" rel="stylesheet" />

    <link href="jQueryFiles/jquery-ui-1.8.16.custom.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />



    <script type="text/javascript" src="jQueryFiles/jquery-1.6.4.min.js"></script>
    <script type="text/javascript" src="jQueryFiles/jquery-ui-1.8.16.custom.min.js"></script>


    <title>Heldesk</title>
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
                        <li><a href="#">Zaloguj się</a></li>
                        <li>/</li>
                        <li><a href="#">Kontakt</a></li>
                        <li>/</li>
                        <li><a href="#">Pomoc</a></li>
                    </ul>
                </div>



                <div id="main">

                    <div id="helpdeskPanel">
                        <div id="helpdeskHeader">
                            <p>Masz problem żeby się zalogować?</p>
                        </div>
                        <div id="helpdeskForm">
                            <img id="helpdeskLoginIconPicture" src="Images/HelpdeskLoginPanel/helpdeskIcon.png" />
                            <div style=" padding-top:10px; border-bottom:1px #d8d3d3 solid;">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:CheckBox ID="loginProblemControl" runat="server" />
                                        </td>
                                        <td>Nie pamiętam loginu
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:CheckBox ID="passwordProblemControl" runat="server" />
                                        </td>
                                        <td>Nie pamietam hasła
                                        </td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                    </tr>
                                </table>
                            </div>
                            <div class="adressEmailContainer" >
                                <table >
                                    <tr>
                                        <td>
                                            Podaj swój adres email
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="emailProblemControl" runat="server" Font-Size="Larger" Width="300"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="ContinueControl" OnClick="ContinueControl_Click" runat="server" Text="Potwierdzenie" CssClass="ContinueControl"/>
                                        </td>
                                        <td></td>
                                            
                                        
                                    </tr>
                                    <tr><td>
                                    <asp:Label ID="ResultControl" runat="server" Text="" CssClass="ResultControl"></asp:Label></td>
                                        </tr>
                                </table>
                                
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
        </div>
    </form>
</body>
</html>
