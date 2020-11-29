<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="AddLoan.aspx.cs" Inherits="Bank2020.admin.AddLoan" %>

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
                    <br /><br /><br /><td> <asp:Label ID="firstnameLbl" runat="server" Text="First Name:"></asp:Label> </td>
                    <td>
                        <asp:DropDownList ID="DropDownList" Class="text" runat="server" DataSourceID="SqlDataSource1" DataTextField="FirstName" DataValueField="ID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:social %>" SelectCommand="SELECT [ID],[FirstName] FROM [customer]"></asp:SqlDataSource>
                    </td>
                </tr>

                <tr>
                    <td><asp:Label ID="principalLbl" runat="server" Text="Principal:"></asp:Label></td>

                    <td><asp:TextBox ID="principalTxt"  Class="text" runat="server" type="number" step="any" ></asp:TextBox></td>
                     <td> 
                    <asp:RequiredFieldValidator ID="principalRFV" runat="server" ControlToValidate="principalTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
               </td>

                </tr>
         <tr>
                    <td><asp:Label ID="interestLbl" runat="server" Text="Interest:"></asp:Label></td>

                    <td><asp:TextBox ID="interestTxt"  Class="text" runat="server" type="number" step="any" ></asp:TextBox></td>
              <td> 
                    <asp:RequiredFieldValidator ID="interestRFV" runat="server" ControlToValidate="interestTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
               </td>

                </tr>

        
                <tr>
                    <td><asp:Label ID="monthLbl" runat="server" Text="Month:"></asp:Label></td>
                    <td><asp:TextBox ID="monthTxt"  Class="text" runat="server" type="number" step="any" ></asp:TextBox></td>
                 <td> 
                    <asp:RequiredFieldValidator ID="monthRFV" runat="server" ControlToValidate="monthTxt" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td> &nbsp;</td>
                    <td> &nbsp;</td>
                </tr>
                   <tr>
           <td>
              <br />&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;    <asp:Button ID="addBtn" runat="server" Text="Add" class="registerbtn" Height="41px" OnClick="Button1_Click"></asp:Button>
           </td>
           <td>
             <br />&nbsp&nbsp&nbsp&nbsp  <asp:Button ID="cancelBtn" runat="server" Text="Cancel" Height="41px" class="cncl" CausesValidation="false" PostBackUrl="~/admin/Loan.aspx"></asp:Button>
           </td>
       </tr>
            </table>
       </center>

</asp:Content>
