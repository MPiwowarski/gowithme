<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainMenu_Menu.ascx.cs" Inherits="GoWithMe.UserControls.MainMenu.ControlTemplates.GoWithMe.MainMenu.MainMenu_Menu" %>

<link href="UserControls/MainMenu/Layouts/GoWithMe.MainMenu/MainMenu.css" rel="stylesheet" />
<div id="MainMenu">
    <ul>
        <li runat="server"><a href="Home.aspx">Home</a></li>
        <li><a href="Registration.aspx">Rejestracja</a></li>
        <li id="LoginMenuItem" runat="server"><a href="LoginPanel.aspx">Zaloguj się</a></li>
       
        <li><a href="#">Kontakt</a></li>
        <li><a href="#">Pomoc</a></li>
        <li>
            <asp:Button ID="LogoutMenuItem" runat="server" Text="Wyloguj się" OnClick="LogoutMenuItem_Click" CssClass="LogoutMenuItemClass"/>
        </li>
    </ul>
</div>
