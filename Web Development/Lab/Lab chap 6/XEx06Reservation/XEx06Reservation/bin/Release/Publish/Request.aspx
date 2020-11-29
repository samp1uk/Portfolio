<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Request.aspx.cs" Inherits="XEx06Reservation.Request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chapter 6: Reservations</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <%--<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6/jquery.min.js" type="text/javascript"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("#txtArrivalDate").datepicker({
                numberOfMonths: 2,
                onSelect: function (selected) {
                    var dt = new Date(selected);
                    dt.setDate(dt.getDate());
                    $("#txtDepartureDate").datepicker("option", "Arrival Date", dt);
                }
            });
            $("#txtDepartureDate").datepicker({
                numberOfMonths: 2,
                onSelect: function (selected) {
                    var dt = new Date(selected);
                    dt.setDate(dt.getDate());
                    $("#txtArrivalDate").datepicker("option", "Departure Date", dt);
                }
            });
        });
    </script>--%>
</head>
<body>
    <div class="container">
        <header class="jumbotron">
            <img src="Images/logo.png" alt="Royal Inns and Suites" />
        </header>

        <main>
            <form id="form1" runat="server" class="form-horizontal">
                <h1>Reservation Request</h1>

                <h3>Request data</h3>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Arrival Date</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtArrivalDate" runat="server"
                            CssClass="form-control" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="requiredFieldArrivalDate" runat="server" ErrorMessage="Please Select a Date." ControlToValidate="txtArrivalDate" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="compareValidatorArrivalDate" runat="server" ErrorMessage="Date Should be the Current Date or Greater Then Current Date." ControlToValidate="txtArrivalDate" Type="Date" Display="Dynamic" ForeColor="Red" Operator="GreaterThanEqual"></asp:CompareValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Departure Date</label>
                    <div class="col-sm-4">
                        <!-- text box -->
                        <asp:TextBox ID="txtDepartureDate" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="requiredFieldDepDate" runat="server" ErrorMessage="A Date is Required." Display="Dynamic" ControlToValidate="txtDepartureDate" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator runat="server" ControlToCompare="txtArrivalDate" Operator="GreaterThanEqual" Display="Dynamic" ValueToCompare="DateTime.Today.ToShortDateString()" Type="Date" ControlToValidate="txtDepartureDate" ForeColor="Red" ErrorMessage="Date Should be the Current Date or Greater Then Current Date."></asp:CompareValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Number of people</label>
                    <div class="col-sm-4">
                        <!-- drop-down -->
                        <asp:DropDownList ID="dropDownNumPeople" runat="server" CssClass="form-control">
                            <asp:ListItem Selected="True">1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Bed type</label>
                    <div class="col-sm-9 bedtype">
                        <!-- radio buttons -->
                        <asp:RadioButtonList ID="radioBedType" runat="server" CssClass="bedtype">
                            <asp:ListItem Selected="True">King</asp:ListItem>
                            <asp:ListItem>Two Queen</asp:ListItem>
                            <asp:ListItem>One Queen</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>

                <h3>Special requests</h3>
                <div class="form-group">
                    <div class="col-sm-7">
                        <!-- multiline text box -->
                        <asp:TextBox ID="txtSpecialReq" runat="server" CssClass="form-control" Rows="4" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>

                <h3>Contact information</h3>
                <div class="form-group">
                    <label class="col-sm-3 control-label">First Name</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorFirstName" runat="server" ErrorMessage="First Name is Required." ControlToValidate="txtFirstName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regularExpressionValidatorFirstName" runat="server" ControlToValidate="txtFirstName" ValidationExpression="^[a-zA-Z'.\s]{1,50}"
                            Text="Enter a Valid Name." Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Last Name</label>
                    <div class="col-sm-4">
                        <!-- text box -->
                        <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorLastName" runat="server" ErrorMessage="Last Name is Required." ControlToValidate="txtLastName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regularExpressionValidatorLastName" runat="server" ControlToValidate="txtLastName" ValidationExpression="^[a-zA-Z'.\s]{1,50}"
                            Text="Enter a Valid Name." Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Email address</label>
                    <div class="col-sm-4">
                        <!-- text box -->
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorEmail" runat="server" ErrorMessage="Please Enter a Email Address." ControlToValidate="txtEmail" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regularExpressionValidatorEmail" runat="server" ErrorMessage="Invalid Email Format." ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Telephone number</label>
                    <div class="col-sm-4">
                        <!-- text box -->
                        <asp:TextBox ID="txtPhoneNum" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="requiredFieldValidatorTelNum" runat="server" ErrorMessage="Please Enter a Phone Number" ControlToValidate="txtPhoneNum" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regularExpressionValidatorTelNum" runat="server" ErrorMessage="Invalid Phone Number Format. Number must be ten digit long." Display="Dynamic" ControlToValidate="txtPhoneNum" ValidationExpression="^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$" ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Preferred method</label>
                    <div class="col-sm-4">
                        <!-- drop down -->
                        <asp:DropDownList ID="dropDownPreffered" runat="server" CssClass="form-control">
                            <asp:ListItem Selected="True">Email</asp:ListItem>
                            <asp:ListItem>Telephone</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <%-- Submit and Clear buttons --%>
                <div class="form-group">
                    <div class="col-sm-offset-3 col-sm-9">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit"
                            CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear"
                            CssClass="btn btn-primary" OnClick="btnClear_Click" />
                    </div>
                </div>

                <%-- message label --%>
                <div class="form-group">
                    <div class="col-sm-offset-1 col-sm-11">
                        <asp:Label ID="lblMessage" runat="server" CssClass="text-info"></asp:Label>
                    </div>
                </div>

            </form>
        </main>

        <footer>
            <p>
                &copy;
                <asp:Label ID="lblYear" runat="server"></asp:Label>
                Royal Inns and Suites
            </p>
        </footer>
    </div>

</body>
</html>
