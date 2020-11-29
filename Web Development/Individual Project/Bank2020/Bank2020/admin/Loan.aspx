<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="Loan.aspx.cs" Inherits="Bank2020.admin.Loan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        table {
            width: 90%;
        }

        img {
            height: 200px;
            width: 200px;
        }

        .auto-style1 {
            left: 18px;
            top: 32px;
        }
    </style>
    <div class="container" style="margin: auto;">
        <br />
        <br />
        <br />
        <div class="row">
            <div class="col-2 m-2">
                <asp:Button ID="addBtn" class="registerbtn" runat="server" Text="Add Loan" PostBackUrl="~/admin/AddLoan.aspx" />
            </div>
        </div>
        <div class="row">
            <div class="col-2 m-3">
                <asp:Label ID="nameLbl" runat="server" Text="Select a customer:" Font-Bold="True"></asp:Label>
                <asp:DropDownList ID="nameDropDownList" Class="text dropdown dropdown-item" runat="server" DataSourceID="SqlDataSource2" DataTextField="FirstName" DataValueField="ID" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" CssClass="dropdown-item"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:social %>" SelectCommand="SELECT [ID],[FirstName] FROM [customer]"></asp:SqlDataSource>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12 m-2">
                <asp:GridView ID="GridViewOne" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" AutoGenerateSelectButton="True" OnSelectedIndexChanged="LoanSelectedIndexChanged">
                    <Columns>


                        <asp:BoundField DataField="principal" HeaderText="Principal" SortExpression="name" />
                        <asp:BoundField DataField="interest" HeaderText="Interest" SortExpression="name" />
                        <asp:BoundField DataField="month" HeaderText="Month" SortExpression="name" />
                        <asp:BoundField DataField="fkcustomerid" HeaderText="FK Customer ID" SortExpression="id" />

                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />

                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </div>
            <div class="container">
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-4 m-2">
                        <h1>
                            <asp:Label ID="lblTableTitle" class=" badge badge-info" runat="server" Text=""></asp:Label>

                        </h1>
                    </div>
                </div>
            </div>
            <div class=" col-lg-12 m-2">
                <span class="badge badge-primary"></span>

                <asp:Label ID="lblmonthlyPayment" class="badge badge-info" runat="server" Text=""></asp:Label>
                <asp:Label ID="lbltotalOfPay" class="badge badge-info" runat="server" Text=""></asp:Label>
                <asp:Label ID="lbltotalInterestPaid" class="badge badge-info" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblpayOffDate" class="badge badge-info" runat="server" Text=""></asp:Label>

                <asp:GridView ID="GridViewAmortization" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <Columns>


                        <asp:BoundField DataField="Month" HeaderText="Month" SortExpression="name" />
                        <asp:BoundField DataField="Starting Balance" HeaderText="Starting Balance" SortExpression="name" />
                        <asp:BoundField DataField="You Paid" HeaderText="You Paid" SortExpression="name" />
                        <asp:BoundField DataField="Interest" HeaderText="Interest" SortExpression="name" />
                        <asp:BoundField DataField="Principal" HeaderText="Principal" SortExpression="name" />
                        <asp:BoundField DataField="Ending Balance" HeaderText="Ending Balance" SortExpression="name" />
                        <asp:BoundField DataField="Total Interest" HeaderText="Total Interest" SortExpression="name" />

                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>

            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:social %>" DeleteCommand="DELETE FROM [loan] WHERE [id] = @id" InsertCommand="INSERT INTO [loan] ([fkcustomerid], [principal], [interest],[month]) VALUES (@fkcustomerid, @principal,@interest, @month)" SelectCommand="SELECT * FROM [loan]" UpdateCommand="UPDATE [loan] SET [fkcustomerid] = @fkcustomerid, [principal] = @principal,[interest] = @interest, [month] = @month WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="fkcustomerid" Type="String" />
            <asp:Parameter Name="principal" Type="String" />
            <asp:Parameter Name="interest" Type="String" />
            <asp:Parameter Name="month" Type="String" />

        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="fkcustomerid" Type="String" />
            <asp:Parameter Name="principal" Type="String" />
            <asp:Parameter Name="interest" Type="String" />
            <asp:Parameter Name="month" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
