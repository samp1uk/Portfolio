<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="Bank2020.admin.AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .registerbtn {
            background-color: #4CAF50;
            color: white;
            padding: 5px;
            margin: auto;
            border: none;
            cursor: pointer;
            width: 90%;
            opacity: 0.9;
        }

        .cncl {
            background-color: red;
            color: white;
            padding: 5px;
            margin: auto;
            border: none;
            cursor: pointer;
            width: 90%;
            opacity: 0.9;
        }

        .text {
            width: 90%;
            padding: 8px;
            margin: auto;
            display: inline-block;
            border: none;
            background: #cecece;
            outline-color: black;
            border-radius: 2px;
            border-radius: 2px solid black;
            border: #3f3f46;
        }
    </style>
    <center> <table>
                <tr>
                    <br /><br /><br /><td> <asp:Label ID="firstNameLbl" runat="server" Text="First Name:"></asp:Label> </td>
                    <td><asp:TextBox ID="firstNameTxt" Class="text" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="firstNameRFV" runat="server" ControlToValidate="firstNameTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>

                <tr>
                    <td><asp:Label ID="lastNameLbl" runat="server" Text="Last Name:"></asp:Label></td>

                    <td><asp:TextBox ID="lastNameTxt"  Class="text" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="lastNameRFV" runat="server" ControlToValidate="lastNameTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
                

                </tr>
        
                <tr>
                    <td><asp:Label ID="usernameLbl" runat="server" Text="Username:"></asp:Label></td>
                    <td><asp:TextBox ID="usernameTxt"  Class="text" runat="server"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ID="usernameRFV" runat="server" ControlToValidate="usernameTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
                
                </tr>
                
               <tr>
                    <td><asp:Label ID="passwordLbl" runat="server" Text="Password:"></asp:Label></td>
                <td> <asp:TextBox ID="passwordTxt"  Class="text" runat="server"></asp:TextBox></td>
              <td><asp:RequiredFieldValidator ID="passwordRFV" runat="server" ControlToValidate="passwordTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
                
                   </tr>
                <tr>
                    <td><asp:Label ID="image" runat="server" Text="Upload Image:"></asp:Label></td>
                
                    <td><asp:FileUpload ID="imgUpload" runat="server" /></td>
                    
                   </tr>
                <tr>
                    <td></td>
                    <td><asp:Label ID="imageErrorLbl" runat="server" ForeColor="Red"></asp:Label></td>
                </tr>
              
                
          <tr>

           <td>
              <br />&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;    <asp:Button ID="addBtn" runat="server" Text="Add" class="registerbtn" Height="41px" OnClick="Button1_Click"></asp:Button>
           </td>
           <td>
             <br />&nbsp&nbsp&nbsp&nbsp  <asp:Button ID="cancleBtn" runat="server" Text="Cancel" Height="41px" class="cncl" CausesValidation="false"  PostBackUrl="~/admin/user.aspx"></asp:Button>
           </td>
       </tr>
            </table>
       </center>


</asp:Content>
