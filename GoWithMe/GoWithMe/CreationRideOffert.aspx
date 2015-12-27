<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreationRideOffert.aspx.cs" Inherits="GoWithMe.CreationRideOffert" %>

<%@ Register Src="~/UserControls/SearchForm/ControlTemplates/GoWithMe.SearchForm/SearchForm_SearchEngine.ascx" TagPrefix="uc1" TagName="SearchForm_SearchEngine" %>
<%@ Register Src="~/UserControls/UserPanelMenu/ControlTemplates/GoWithMe.UserPanelMenu/UserPanelMenu_Menu.ascx" TagPrefix="uc1" TagName="UserPanelMenu_Menu" %>
<%@ Register Src="~/UserControls/MainMenu/ControlTemplates/GoWithMe.MainMenu/MainMenu_Menu.ascx" TagPrefix="uc1" TagName="MainMenu_Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="css/CreationRideOffert.css" rel="stylesheet" />  
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <link href="jQueryFiles/jquery-ui-1.8.16.custom.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    
    <script type="text/javascript" src="jQueryFiles/jquery-1.6.4.min.js"></script>
    <script type="text/javascript" src="jQueryFiles/jquery-ui-1.8.16.custom.min.js"></script>
    <script src="Scripts/HomeCalendar.js"></script>


    <title>Zaoferuj swój przejazd</title>
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

                <uc1:SearchForm_SearchEngine runat="server" id="SearchForm_SearchEngine" />

                <div id="main">
                    <div id="offerRidePanel">

                        <uc1:UserPanelMenu_Menu runat="server" ID="UserPanelMenu_Menu" />


                        <div id="offerRideData" style="float: left;">
                            <table>
                                <tr>
                                    <td colspan="2">
                                        <h2>Data of ride offert</h2>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="offerRideDataLabels">Departure date: </label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="dateRideControl" runat="server" CssClass="offerRidePanelFields">
                                        </asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="offerRideDataLabels">departure hour: </label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="departureHourControl" runat="server" Width="40"  TextMode="Number"></asp:TextBox>
                                        <p style="display:inline;margin-bottom:30px; font-size:20px;">:</p>
                                        <asp:TextBox ID="departureMinutesControl" runat="server" Width="40"  TextMode="Number"></asp:TextBox>
                                       <p style="display:inline;margin-bottom:10px; font-size:10px;">ustaw godzine z minutami</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="offerRideDataLabels">From:</label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="fromRideControl" runat="server" CssClass="offerRidePanelFields">
                                        </asp:TextBox>

                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="offerRideDataLabels">To:</label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="toRideControl" runat="server" CssClass="offerRidePanelFields">
                                        </asp:TextBox>

                                    </td>
                                </tr>                               
                                <tr>
                                    <td>
                                        <label class="offerRideDataLabels">Price for one sit:</label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="cashToPayControl" runat="server" CssClass="offerRidePanelFields" TextMode="Number">
                                        </asp:TextBox>
                                    </td>
                                </tr>
                                 <tr>
                                    <td>
                                        <label class="offerRideDataLabels">Number of sits:</label>
                                    </td>
                                    <td>          
                                        <asp:TextBox ID="numberOfSitsControl" runat="server" Width="40"  TextMode="Number"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class="offerRideDataLabels">Car model:</label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="carModelControl" runat="server" CssClass="offerRidePanelFields" >
                                        </asp:TextBox>
                                    </td>
                                </tr>
                               
                                <tr>
                                    <td colspan="2">
                                        <label class="offerRideDataLabels">Description:</label>
                                        <asp:TextBox ID="offerRideDescriptionControl" runat="server" CssClass="offerRidePanelFields" TextMode="MultiLine" Rows="10">
                                        </asp:TextBox>
                                    </td>
                                </tr>
                                 <tr>
                                    <td></td>
                                    <td colspan="2">
                                        <asp:Button ID="AcceptBtnControl" runat="server" Text="Add ride offert" CssClass="AcceptButton" OnClick="AcceptBtnControl_Click" />

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
                            <img src="Images/CreationRideOffert/CreationRideOffertIcon.png" id="rideOffertIcon"/>
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
