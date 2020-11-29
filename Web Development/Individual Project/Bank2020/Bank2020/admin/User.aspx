<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Bank2020.admin.User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        table {
            width: 90%;
        }
    </style>
    <div class="container" style="margin: auto;">
        <div class="row">
            <div class="col-lg-3">
                <br />
                <br />
                <br />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-2 m-2">
            <asp:Button ID="addNewBtn" class="registerbtn" runat="server" Text="Add New User" PostBackUrl="~/admin/AddUser.aspx" />
        </div>
    </div>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:social %>" DeleteCommand="DELETE FROM [login] WHERE [ID] = @ID" InsertCommand="INSERT INTO [login] ([firstname], [lastname], [Username], [password], [img]) VALUES (@FirstName, @LastName, @Username, @Password, @img)" SelectCommand="SELECT * FROM [login]" UpdateCommand="UPDATE [login] SET [firstname] = @FirstName, [lastname] = @LastName, [Username] = @Username, [password] = @Password, [img] = @img WHERE [ID] = @ID">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Username" Type="String" />
            <asp:Parameter Name="Password" Type="String" />
            <asp:Parameter Name="img" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Username" Type="String" />
            <asp:Parameter Name="Password" Type="String" />
            <asp:Parameter Name="img" />
            <asp:Parameter Name="ID" />
        </UpdateParameters>
    </asp:SqlDataSource>

    <div class="row">
        <div class="col-lg-12 m-2">

            <div style="width: 100%; overflow: auto;">
                <asp:GridView ID="GridView" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="username" HeaderText="Username" SortExpression="username" />
                        <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
                        <asp:BoundField DataField="firstname" HeaderText="First Name" SortExpression="firstname" />
                        <asp:BoundField DataField="lastname" HeaderText="Last Name" SortExpression="lastname" />
                        <asp:ImageField DataImageUrlField="img" HeaderText="Profile Image" SortExpression="img">
                        </asp:ImageField>
                        <asp:CommandField HeaderText="Operations" ShowDeleteButton="True" ShowEditButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>

        </div>
    </div>

</asp:Content>
