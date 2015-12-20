<%@ Page Language="C#" MasterPageFile="~/BaseSite.Master" AutoEventWireup="true" CodeBehind="Home2.aspx.cs" Inherits="GoWithMe.Home2" %>

<asp:Content ID="Head" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
                     /*2.Changing color in hover jQueryUI*/
                     $(document).ready(function () {
                         $("#ContentPlaceHolderMain_offerRide").hover(function () {
                             $(this).animate({ "backgroundColor": "yellow", "color": "black" }, 200);
                         },
                         //back to custom colors
                     function () {
                         $(this).animate({ "backgroundColor": "darkorange", "color": "black" }, 200);
                     }
                     );
                     });
    </script>


    <title>Home</title>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
     
         <div id="overview" style="">
                <h1 style="float: left">Znajdź przejazd!</h1>
                <asp:Button ID="offerRide" runat="server" Text="Sam zaoferuj przejazd!" Style="float: right" />
                <div id="rideSearch">
                    <ul>
                        <li>
                            <fieldset>
                                <label for="name">Od</label>
                                <asp:TextBox ID="PlaceFromControl" runat="server" Columns="20" CssClass="field"></asp:TextBox>
                            </fieldset>
                        </li>
                        <li>
                            <fieldset>
                                <label for="name">Do</label>
                                <asp:TextBox ID="PlaceToControl" runat="server" Columns="20" CssClass="field"></asp:TextBox>
                            </fieldset>
                        </li>
                        <li>
                            <fieldset>
                                <label for="name">Data</label>
                                <%-- <input type="text" id="date" size="20" class="field" />--%>
                                <asp:TextBox ID="rideDate" runat="server" Columns="20" CssClass="field" Style="background-image: url( Images/Calendar3.jpg );"></asp:TextBox>
                            </fieldset>
                        </li>
                        <li>
                            <fieldset>
                                <label for="name"></label>
                                <asp:Button ID="SearchRideBtnControl" runat="server" Text="Szukaj przejazdu" CssClass="button" OnClick="SearchRideBtnControl_Click" />
                            </fieldset>
                        </li>
                    </ul>
                </div>
                 
            </div>
     <div id="main">

                <div class="left">
                    <h3>Zobacz sam!</h3>
                    <img src="img/tapeta3.png" id="banner" />
                    <p><a href="#" class="btn">Zobacz więcej &raquo;</a></p>
                </div>

                <%-- <div class="right">
                <h3>Kurs Joomla</h3>
                <p>Z naszym kursem dowiesz się jak zbudować nowoczesną stronę internetową opartą na darmowym systemie Joomla. Pokażemy Ci jak zbudować stronę od podstaw. Zaczniemy od instalacji systemu na serwerze. Potem opowiemy o konfiguracji systemu, a następnie przejdziemy do tworzenia zawartości strony internetowej. Dowiesz się również jak korzystać z różnych dodatków. Dzięki nim będziesz mógł na swojej stronie umieścić np. galerię zdjęć czy forum dyskusyjne. Przekonasz się, że Joomla to system o wielkich możliwościach, który jest jednocześnie łatwy w obsłudze.</p>
                <p><a href="#" class="btn">Zobacz więcej &raquo;</a></p>
            </div>--%>
                <div class="right">
                    <%--<asp:ContentPlaceHolder ID="MainContent" runat="server">
                    <h1>Section that changes on a page by page basis</h1>
                </asp:ContentPlaceHolder>--%>
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
</asp:Content>
