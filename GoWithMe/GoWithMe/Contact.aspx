<%@ Page Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="GoWithMe.Contact" %>


<asp:Content ID="Head" ContentPlaceHolderID="head" runat="server">
    <link href="css/Contact.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <title>Contact</title>
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="mainContent" runat="server">
    <div class="ContactForm">

        <h2>To contact us just fill the form and click 'Send message'. We will answer you as soon as possible.</h2>

        <div class="ContactFormContent">
            <table>
                <tr>
                    <td>
                        <label class="ContactLabel">Your email</label>
                    </td>
                    <td>
                        <asp:TextBox ID="EmailControl" runat="server" CssClass="ContactField"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label class="ContactLabel">Your Name or nick</label>
                    </td>
                    <td>
                        <asp:TextBox ID="NameControl" runat="server" CssClass="ContactField"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label class="ContactLabel TopicLabel">Topic</label>
                    </td>
                    <td>
                        <asp:TextBox ID="TopicControl" runat="server" CssClass="ContactField"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <label class="ContactLabel">Description</label>

                        <asp:TextBox ID="DescriptionControl" runat="server" CssClass="ContactField DescriptionField" TextMode="MultiLine" Rows="10">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="statusControl" runat="server" Font-Bold="true"></asp:Label></td>
                    <td>
                        <asp:Button ID="AcceptBtnControl" runat="server" Text="Send message" CssClass="SendMessage_ContactBtn" OnClick="AcceptBtnControl_Click" />

                    </td>
                </tr>
               

            </table>
        </div>
        <div class="ContactBanner">
            <img src="Images/Contact/contactUs.jpg" />
        </div>
    </div>
</asp:Content>
