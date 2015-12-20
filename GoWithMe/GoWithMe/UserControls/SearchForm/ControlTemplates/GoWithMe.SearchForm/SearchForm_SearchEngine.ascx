<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchForm_SearchEngine.ascx.cs" Inherits="GoWithMe.SearchForm.SearchEngine" %>

<link href="jQueryFiles/jquery-ui-1.8.16.custom.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
<script type="text/javascript" src="jQueryFiles/jquery-1.6.4.min.js"></script>
<script type="text/javascript" src="jQueryFiles/jquery-ui-1.8.16.custom.min.js"></script>

<script src="UserControls/SearchForm/Scripts/UserControlsSearchEngine.js"></script>
<link href="UserControls/SearchForm/Layouts/GoWithMe.SerchForm/SearchForm.css" rel="stylesheet" />



<div id="rideSearch" runat="server" onload="rideSearch_Load">
    <ul>
        <li>
            <fieldset>
                <label for="name">Od</label>
                <asp:TextBox ID="PlaceFromControl" runat="server" Columns="20" CssClass="field" Width="220"></asp:TextBox>
            </fieldset>
        </li>
        <li>
            <fieldset>
                <label for="name">Do</label>
                <asp:TextBox ID="PlaceToControl" runat="server" Columns="20" CssClass="field" Width="220"></asp:TextBox>
            </fieldset>
        </li>
        <li>
            <fieldset>
                <label for="name">Data</label>
                <asp:TextBox ID="rideDate" runat="server" Columns="20" CssClass="field" Style="background-image: url( ../../../../Images/Calendar3.jpg );" Width="150" ></asp:TextBox>
            </fieldset>
        </li>
        <li>
            <fieldset>
                <label for="name"></label>
                <asp:Button ID="SearchRideBtnControl" runat="server" Text="Szukaj przejazdu" CssClass="SearchButton" OnClick="SearchRideBtnControl_Click" />
            </fieldset>
        </li>
        <li>
            <asp:Label ID="SearchStatusControl" runat="server" Text=""></asp:Label>
        </li>
    </ul>
</div>
