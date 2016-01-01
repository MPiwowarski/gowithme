<%@ Page Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="MyOfferts.aspx.cs" Inherits="GoWithMe.MyOfferts" %>

<%@ Register Src="~/UserControls/SearchForm/ControlTemplates/GoWithMe.SearchForm/SearchForm_SearchEngine.ascx" TagPrefix="uc1" TagName="SearchForm_SearchEngine" %>
<%@ Register Src="~/UserControls/UserPanelMenu/ControlTemplates/GoWithMe.UserPanelMenu/UserPanelMenu_Menu.ascx" TagPrefix="uc1" TagName="UserPanelMenu_Menu" %>


<asp:Content ID="Head" ContentPlaceHolderID="head" runat="server">
    <link href="css/MyOfferts.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <title>My offerts</title>
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="mainContent" runat="server">
    <div class="MyOffertsMainContainer">
        <div id="SearchEngine">
            <uc1:SearchForm_SearchEngine runat="server" ID="SearchForm_SearchEngine" />
        </div>

        <uc1:UserPanelMenu_Menu runat="server" ID="UserPanelMenu_Menu" />
        <asp:Button ID="DeleteSelectedControl" runat="server" Text="Delete selected" OnClick="DeleteSelectedControl_Click" />
        <div id="MyOffertsForm">
            <div id="ListOfferts" runat="server">
                
            </div>           
        </div>
      
    </div>
</asp:Content>
