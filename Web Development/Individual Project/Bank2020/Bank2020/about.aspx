<%@ Page Title="" Language="C#" MasterPageFile="~/head.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="Bank2020.about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="background-color: #f2f2f2">
        <div class="row">
            <div class="col-12">
                <asp:Label ID="aboutLbl" runat="server" Text="ABOUT US" Font-Size="XX-Large"></asp:Label>
            </div>
            <div class="col-md-6">
                <br />

                <p>
                    Bank 2020 is a locally owned, locally loaned community bank that provides a variety of core financial services to businesses, professionals, and individuals. We promise our customers immediate, direct access to our bank decision makers and deliver the finest personalized service in the industry. Centric has committed people and resources to enrich the communities where we live and work. Because trust is our most important commodity, we are focused on building and sustaining long-term generational relationships with our customers, our community, our employees, and our shareholders. In every transaction, We Revolve Around You.
                </p>
            </div>
            <div class="col-md-6">
                <br />
                <asp:Image ID="Image" runat="server" Height="312px" ImageUrl="~/imgs/HomeImage4.jpg" Width="449px" />
            </div>
            <div class="col-md-6">
                <br />
                <asp:Label ID="misionLbl" runat="server" Text="Our Mission" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                <ul>
                    <li>To provide the best service for our customer. </li>
                    <li>To provide customer with comfort, similar to home.  </li>
                    <li>To ensure all our customer leave with a smile and enjoyed there stay and visit to the our bank. </li>
                </ul>


            </div>
            <div class="col-md-6">
                <br />
                <asp:Label ID="VisionLbl" runat="server" Text="Our Vision" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                <p>
                    To be a financially viable, independent community bank that is committed to improving the quality of life of the communities we serve.

To earn the loyalty of employees, customers and the community by operating with integrity and fairness at all times.

To demonstrate behavior that totally focuses on the customer and recognize they are the reason we are here.
                </p>
            </div>
            <div class="col-md-6">
                <br />
                <asp:Image ID="ImageTwo" runat="server" Height="312px" ImageUrl="~/imgs/HomeImage2.jpg" Width="449px" />
            </div>
            <div class="col-md-6">
                <br />

                <p>
                    To have employees who are empowered to build long-term relationships with our customers.

To provide our shareholders long-term growth and an attractive return on their investment in the bank.

To satisfy the customer’s needs by offering a myriad of products that are driven by a sales and service philosophy.
                </p>
            </div>

        </div>
    </div>
</asp:Content>
