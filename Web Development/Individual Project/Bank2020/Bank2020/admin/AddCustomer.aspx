<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="Bank2020.admin.AddCustomer" %>

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
                    <td><asp:TextBox ID="firstNameTxt" Class="text" runat="server" ></asp:TextBox></td>                
                <td> 
                    <asp:RequiredFieldValidator ID="firstNameRFV" runat="server" ControlToValidate="firstNameTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
               </td>
                </tr>

                <tr>
                    <td><asp:Label ID="lastNameLbl" runat="server" Text="Last Name:" ></asp:Label></td>
                    <td><asp:TextBox ID="lastNameTxt"  Class="text" runat="server" ></asp:TextBox></td>                   
                <td> 
                    <asp:RequiredFieldValidator ID="lastNameRFV" runat="server" ControlToValidate="lastNameTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
               </td>
                </tr>
        
                <tr>
                    <td><asp:Label ID="addressLbl" runat="server" Text="Address:"></asp:Label></td>
                    <td><asp:TextBox ID="addressTxt"  Class="text" runat="server"  ></asp:TextBox></td>               
                <td> 
                    <asp:RequiredFieldValidator ID="addressRFV" runat="server" ControlToValidate="addressTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
               </td>
                </tr>
                
               <tr>
                    <td><asp:Label ID="ageLbl" runat="server" Text="Age" ></asp:Label></td>
                <td> <asp:TextBox ID="ageTxt"  Class="text" runat="server" TextMode="Number" ></asp:TextBox></td>
              <td> 
                    <asp:RequiredFieldValidator ID="ageRFV" runat="server" ControlToValidate="ageTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
               </td>
                   </tr>
                   <tr>
           <td>
              <br />&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;    <asp:Button ID="addBtn" runat="server" Text="Add" class="registerbtn" Height="41px" OnClick="Button1_Click"  ></asp:Button>
           </td>
           <td>
             <br />&nbsp&nbsp&nbsp&nbsp  <asp:Button ID="cancleBtn" runat="server" Text="Cancel" Height="41px" class="cncl" CausesValidation="false"  PostBackUrl="~/admin/Customer.aspx"></asp:Button>
           </td>
       </tr>
            </table>
       </center>


</asp:Content>
