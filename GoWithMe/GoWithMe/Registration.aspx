<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="GoWithMe.Registration" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<%@ Register Src="~/UserControls/MainMenu/ControlTemplates/GoWithMe.MainMenu/MainMenu_Menu.ascx" TagPrefix="uc1" TagName="MainMenu_Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <link href="css/Registration.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
    <link href="css/LoginForm.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />

    <link href="jQueryFiles/jquery-ui-1.8.16.custom.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />

    <script type="text/javascript" src="jQueryFiles/jquery-1.6.4.min.js"></script>
    <script type="text/javascript" src="jQueryFiles/jquery-ui-1.8.16.custom.min.js"></script>
    <script type="text/javascript" src="Scripts/HomeCalendar.js"></script>


    <script type="text/javascript">
        function showLightbox() {
            $('#lightBox').fadeIn(500);
        }
        function hideLightbox() {
            $('#lightBox').fadeOut(500);
        }
    </script>


    <title>Rejestracja</title>
</head>
<body>
    <form id="form2" runat="server">
   


        <div id="wrapper">

            <div id="logo">
                <h1>Go With Me
                </h1>
            </div>


            
            <uc1:MainMenu_Menu runat="server" ID="MainMenu_Menu" />


            <div id="main">

                <div class="left" style="width: 60%">
                    <h3>Register and join us!</h3>
                    <div id="registrationPanel">
                        <table>
                            <tr>
                                <td colspan="2">
                                    <h2>Registration panel</h2>
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
                                        ErrorMessage="Field 'Email' is required."
                                        ControlToValidate="emailControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail"
                                        runat="server" ErrorMessage="Given email is wrong."
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
                                        ErrorMessage="Field 'Login' is required."
                                        ControlToValidate="loginControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Password</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="passwordControl" runat="server" CssClass="registrationPanelFields"
                                        TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="field 'Password' is required."
                                        ControlToValidate="passwordControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Confirm password</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="confirmPasswordControl" runat="server" TextMode="Password"
                                        CssClass="registrationPanelFields"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="Field 'Submit password' is required."
                                        ControlToValidate="confirmPasswordControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>

                                    <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
                                        ErrorMessage="Passwords are not the same."
                                        ControlToValidate="confirmPasswordControl" ControlToCompare="passwordControl"
                                        Operator="Equal" Type="String" ForeColor="Red" Text="*">
                                    </asp:CompareValidator>
                                </td>
                            </tr>
                            <tr style="border-top: solid black 3px">
                                <td>
                                    <label class="registrationPanelLabels">Name </label>
                                </td>
                                <td>
                                    <asp:TextBox ID="nameControl" runat="server" CssClass="registrationPanelFields">
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorImie"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="Field 'Name' is required."
                                        ControlToValidate="nameControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Surname </label>
                                </td>
                                <td>
                                    <asp:TextBox ID="surnameControl" runat="server" CssClass="registrationPanelFields">
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                                        runat="server" ForeColor="Red"
                                        ErrorMessage="Field 'Surname' is required."
                                        ControlToValidate="surnameControl" Display="Dynamic" Text="*">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registrationPanelLabels">Phone number </label>
                                </td>
                                <td>
                                    <asp:ScriptManager ID="ScriptMan1" runat="server">
                                    </asp:ScriptManager>
                                    <div>
                                        <asp:TextBox ID="phoneNumberControl" runat="server" CssClass="registrationPanelFields"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumerTelefonu"
                                            runat="server" ForeColor="Red"
                                            ErrorMessage="Field 'Phone number' is required"
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
                                    <asp:Button ID="ClearFormControl" runat="server" Text="Clear form" CssClass="button" OnClick="ClearFormControl_Click" CausesValidation="False" />

                                </td>
                                <td colspan="2">
                                    <asp:Button ID="RegisterBtnControl" runat="server" Text="REGISTER" CssClass="button" OnClick="RegisterBtnControl_Click" />

                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                                        ForeColor="Red" HeaderText="REGISTRATION FAILED:" ShowMessageBox="False"
                                        ShowSummary="true" DisplayMode="List" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Label ID="statusControl" runat="server" Font-Bold="true"></asp:Label>
                                </td>
                            </tr>



                        </table>


                     
                    </div>

                </div>

                <div class="right" style="width: 35%">
                    <h3>Just see!</h3>
                    <img src="img/tapeta3.png" id="banner" />
                    <p><a href="Home.aspx" class="btn">See more! &raquo;</a></p>
                </div>
                <div class="right" style="width: 35%;">
                    <img src="img/TerazZawszeBaner.png" id="banner2" />
                    <p><a href="Home.aspx" class="btn">See more! &raquo;</a></p>
                </div>

                <br class="clearit" />

            </div>

        </div>

    
    </form>
</body>
</html>
