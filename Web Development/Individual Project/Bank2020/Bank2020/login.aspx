<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Bank2020.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .div1 {
            background-color: #f2f2f2;
            width: 32%;
            height: 450px;
            margin: auto;
            border: 4px solid #ccc;
            margin-top: 120px;
        }

        .auto-style1 {
            width: 100%;
            height: 337px;
        }

        .auto-style2 {
            width: 129px;
        }

        .auto-style3 {
            width: 254px;
        }

        .field {
            width: 100%;
            padding: 10px 20px;
            margin: 8px 0;
            display: inline-block;
            border-radius: 1px solid #ccc;
            box-sizing: border-box;
        }

        .button {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
        }

            .button:hover {
                opacity: 0.8;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div1">


            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;
                    <br />
                        <asp:Image ID="loginImage" runat="server" Width="202px" Height="133px" ImageUrl="~/imgs/login/man-grey.png" />
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="userLbl" runat="server" Text="Username:" Font-Names="Arial"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="usernameRFV" runat="server"
                            ErrorMessage="A username is required" ControlToValidate="usernameBox" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="usernameBox" runat="server" class="field">johnadams</asp:TextBox>
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="passLbl" runat="server" Text="Password:" Font-Names="Arial"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="passwordRFV" runat="server"
                            ErrorMessage="A password is required" ControlToValidate="passwordBox" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="passwordBox" class="field" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="passwordLbl" runat="server" Text="(pw1)"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="errorLbl" runat="server" ForeColor="Red"></asp:Label>
                        <asp:Button ID="loginBtn" Text="Login" runat="server" Class="button"
                            OnClick="Button1_Click" />
                        <asp:Button ID="homeBtn" runat="server" Class="button" Text="Home Page" OnClick="homeBtn_Click" CausesValidation="False" />
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>


        </div>
        </div>
    </form>
</body>
</html>
