<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainMenu_Menu.ascx.cs" Inherits="GoWithMe.UserControls.MainMenu.ControlTemplates.GoWithMe.MainMenu.MainMenu_Menu" %>

<link href="UserControls/MainMenu/Layouts/GoWithMe.MainMenu/MainMenu.css" rel="stylesheet" />
<div id="MainMenu">
    <ul>
        <li runat="server"><a href="Home.aspx">Home</a></li>
        <li><a href="Registration.aspx">Registratioin</a></li>
        <li id="LoginMenuItem" runat="server"><a href="LoginPanel.aspx">Login</a></li>
       
        <li><a href="Contact.aspx">Contact</a></li>
        <li><a href="Help.aspx">Help</a></li>
        <li id="UserPanelMenuItem" runat="server"><a href="UserPanel.aspx">User Panel</a></li>
        <li>
            <asp:Button ID="LogoutMenuItem" runat="server" Text="Logout" OnClick="LogoutMenuItem_Click" CssClass="LogoutMenuItemClass"/>
        </li>
    </ul>
</div>
