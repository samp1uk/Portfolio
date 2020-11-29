<%@ Page Title="" Language="C#" MasterPageFile="~/head.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Bank2020.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="background-color: #f2f2f2">
        <div class="row">
            <div class="col-md-6">
                <br />
                <asp:Label ID="titleLbl" runat="server" Text="Bank2020 By Sohal Patel:" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                <p>Want a mortgage that meets your needs? Choose one of Merchants Bank's mortgage lending experts . We offer a complete line of mortgage options, at a mortgage rate you’ll like, backed by the service and experience of our mortgage team.</p>
            </div>
            <div class="col-md-6">
                <br />
                <asp:Image ID="Image_1" runat="server" Height="312px" ImageUrl="~/imgs/HomeImage2.jpg" Width="449px" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">

                <asp:Image ID="Image_2" runat="server" Height="312px" ImageUrl="~/imgs/HomeImage4.jpg" Width="449px" />
            </div>

            <div class="col-md-6">
                <br />
                <asp:Label ID="aboutLbl" runat="server" Text="About Us" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                <p>
                    The differences between mortgage or home loan options can sometimes be confusing. Below is a list of the types of mortgages we offer with a brief review of each.
                </p>
            </div>
            <div class="col-md-6">
                <br />
                <br />
                <asp:Label ID="serviceLbl" runat="server" Text="Our Services:" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                <p>Below are some of our amazing serivces that we offer.</p>
            </div>
            <div class="col-md-6">
            </div>
            <div class="col-md-3">


                <br />
                <asp:Image ID="Image_3" runat="server" ImageUrl="~/imgs/HomeImage3.jpg" Style="width: 100%; height: 200px" />

                <br />
                <asp:Label ID="ccLbl" runat="server" Text="Credit Card:" Font-Bold="True" Font-Size="Medium"></asp:Label>
                <p>Choose from our Bank 2020 credit cards to help you buy what you need. Many offer rewards that can be redeemed for cash back, or for rewards at companies like Disney, Marriott, Hyatt, United or Southwest Airlines. We can help you find the credit card that matches your lifestyle. Plus, get your free credit score!</p>

            </div>
            <div class="col-md-3">
                <br />
                <asp:Image ID="Image_4" runat="server" ImageUrl="~/imgs/HomeImage5.jpg" Style="width: 100%; height: 200px" />

                <br />
                <asp:Label ID="IncomeLbl" runat="server" Text="Income Monitoring:" Font-Bold="True" Font-Size="Medium"></asp:Label>
                <p>Whether you choose to work with a financial advisor and develop a financial strategy or invest online, J.P. Morgan offers insights, expertise and tools to help you reach your goals.</p>
            </div>
            <div class="col-md-3">
                <br />
                <asp:Image ID="Image_5" runat="server" ImageUrl="~/imgs/HomeImage2.jpg" Style="width: 100%; height: 200px" />

                <br />
                <asp:Label ID="loanLbl" runat="server" Text="Loans Consulting: " Font-Bold="True" Font-Size="Medium"></asp:Label>
                <p>Bank 2020 is here to help you get the right car. Apply for an auto loan for a new or used car or refinance your existing car loan with Chase. Use the payment calculator to estimate monthly payments.</p>
            </div>
            <div class="col-md-3">
                <br />
                <asp:Image ID="Image_6" runat="server" ImageUrl="~/imgs/HomeImage4.jpg" Style="width: 100%; height: 200px" />

                <br />
                <asp:Label ID="financialLbl" runat="server" Text="Financial Management:" Font-Bold="True" Font-Size="Medium"></asp:Label>
                <p>Financial Management is the process of finding relevant points of comparison for financial and other quantitative analyses. To a large extent, benchmarking is as much an art as a science. Do it incorrectly, and you can promote flawed decision making that is costly to the organization. Moreover, clever corporate politicians realize that they can push decisions in their desired direction through a crafty choice of benchmarks in their analyses.</p>
            </div>
        </div>

    </div>
</asp:Content>
