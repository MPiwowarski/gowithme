<%@ Page Language="C#" MasterPageFile="~/BaseSite.Master" AutoEventWireup="true" CodeBehind="Registration2.aspx.cs" Inherits="GoWithMe.Registration2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>

<asp:Content ID="Head" ContentPlaceHolderID="head" runat="server">
    <title>Rejestracja</title>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
       <div id="main">

                <div class="left" style="width: 60%">
                    <h3>Zarejestruj się i dołącz do nas!</h3>
                    <div id="registrationPanel">
                        <table>
                            <tr>
                                <td colspan="2">
                                    <h2>Rejestracja użytkownika</h2>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Email</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="emailControl" runat="server" CssClass="registrationPanelFields">
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="Pole 'Email' jest wymagane."
                                        ControlToValidate="emailControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail"
                                        runat="server" ErrorMessage="Podany adres email jest nieprawidłowy."
                                        ControlToValidate="emailControl" ForeColor="Red"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        Text="*">
                                    </asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Login </label>
                                </td>
                                <td>
                                    <asp:TextBox ID="loginControl" runat="server" CssClass="registrationPanelFields">
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogin"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="Pole 'Login' jest wymagane."
                                        ControlToValidate="loginControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Hasło</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="passwordControl" runat="server" CssClass="registrationPanelFields"
                                        TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="Pole 'Hasło' jest wymagane."
                                        ControlToValidate="passwordControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Potwierdź hasło</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="confirmPasswordControl" runat="server" TextMode="Password"
                                        CssClass="registrationPanelFields"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="Pole 'Potwierdź hasło' jest wymagane."
                                        ControlToValidate="confirmPasswordControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>

                                    <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
                                        ErrorMessage="Hasła nie zgadzają się."
                                        ControlToValidate="confirmPasswordControl" ControlToCompare="passwordControl"
                                        Operator="Equal" Type="String" ForeColor="Red" Text="*">
                                    </asp:CompareValidator>
                                </td>
                            </tr>
                            <tr style="border-top: solid black 3px">
                                <td>
                                    <label class="registrationPanelLabels">Imię </label>
                                </td>
                                <td>
                                    <asp:TextBox ID="nameControl" runat="server" CssClass="registrationPanelFields">
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorImie"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="Pole 'Imie' jest wymagane."
                                        ControlToValidate="nameControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Nazwisko </label>
                                </td>
                                <td>
                                    <asp:TextBox ID="surnameControl" runat="server" CssClass="registrationPanelFields">
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="Pole 'Nazwisko' jest wymagane."
                                        ControlToValidate="surnameControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Numer telefonu </label>
                                </td>
                                <td>
                                    <asp:ScriptManager ID="ScriptMan1" runat="server">
                                    </asp:ScriptManager>
                                    <div>
                                        <asp:TextBox ID="phoneNumberControl" runat="server" CssClass="registrationPanelFields"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumerTelefonu"
                                            runat="server" ForeColor="Red"
                                            ErrorMessage="Pole 'Numer telefonu' jest wymagane."
                                            ControlToValidate="phoneNumberControl" Display="Dynamic" Text="*">
                                        </asp:RequiredFieldValidator>

                                        <ajaxToolkit:MaskedEditExtender TargetControlID="phoneNumberControl" Mask="999-999-999"
                                            MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus" OnInvalidCssClass="MaskedEditError"
                                            MaskType="Number" InputDirection="LeftToRight" AcceptNegative="None" DisplayMoney="None"
                                            ErrorTooltipEnabled="True" runat="server" ID="mskD" />
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <recaptcha:RecaptchaControl ID="recaptcha" runat="server"
                                        PublicKey="6LdwWxATAAAAAKclahK0ViQO88v8qJ-jCxmrBYAF"
                                        PrivateKey="6LdwWxATAAAAAMcLIcEdWhq6hS-k6Qcl0QwqwuQI" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="ClearFormControl" runat="server" Text="Wyczyść formularz" CssClass="button" OnClick="ClearFormControl_Click" CausesValidation="False" />

                                </td>
                                <td colspan="2">
                                    <asp:Button ID="RegisterBtnControl" runat="server" Text="Zarejestruj" CssClass="button" OnClick="RegisterBtnControl_Click" />

                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                                        ForeColor="Red" HeaderText="REJESTRACJA NIE POWIODŁA SIĘ:" ShowMessageBox="False"
                                        ShowSummary="true" DisplayMode="List" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Label ID="statusControl" runat="server" Font-Bold="true"></asp:Label>
                                </td>
                            </tr>



                        </table>


                        <%--<table >
                            <tr>
                                <td>
                                    <label for="name" class="registrationPanelLabels">Imię</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="NameControl" runat="server" Columns="20" CssClass="registrationPanelFields"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label for="name" class="registrationPanelLabels">Nazwisko</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="SurnameControl" runat="server" Columns="20" CssClass="registrationPanelFields"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                 <td>
                                    <label for="name" class="registrationPanelLabels">Nazwisko</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" Columns="20" CssClass="registrationPanelFields"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label for="name"></label>
                                </td>
                                <td>
                                    <asp:Button ID="RegisterBtnControl" runat="server" Text="Zarejestruj" CssClass="button" />
                                </td>
                            </tr>
                        </table>--%>
                    </div>

                </div>

                <div class="right" style="width: 35%">
                    <h3>Zobacz sam!</h3>
                    <img src="img/tapeta3.png" id="banner" />
                    <p><a href="Home.aspx" class="btn">Zobacz więcej &raquo;</a></p>
                </div>
                <div class="right" style="width: 35%;">
                    <img src="img/TerazZawszeBaner.png" id="banner2" />
                    <p><a href="Home.aspx" class="btn">Zobacz więcej &raquo;</a></p>
                </div>

                <br class="clearit" />

            </div>
</asp:Content>
