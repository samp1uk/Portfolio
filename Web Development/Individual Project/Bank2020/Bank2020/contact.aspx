<%@ Page Title="" Language="C#" MasterPageFile="~/head.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Bank2020.contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-12">
                <br />
                <h2>Locate Us on Map</h2>
                <br />
                <p>
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d149606.66938108855!2d-118.46972024579001!3d34.04716525130965!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xd5c114347200353c!2sU.S.%20Bank%20Branch!5e0!3m2!1sen!2sae!4v1586147690125!5m2!1sen!2sae" width="100%" height="500" frameborder="0" style="border: 0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>
                </p>
            </div>
            <div class="col-6">
                <h6 class="text-uppercase font-weight-bold">Contact Us</h6>
                <hr class="deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto" style="width: 60px;">
                <p>
                    <i class="fas fa-home mr-3"></i>LA – United States
                </p>
                <p style="font-size: 14px">
                    <i class="fas fa-envelope mr-3"></i>info@bank2020.com
                </p>
                <p>
                    <i class="fas fa-phone mr-3"></i>+1 783 222 1110
                </p>
                <p>
                    <i class="fa fa-whatsapp mr-3"></i>+1 974 567 1234
                </p>

            </div>
            <div class="col-6">
                <table>

                    <tr>
                        <td>
                            <a href="mailto:abc@gmail.com">
                                <asp:Image runat="server" ImageUrl="~/imgs/logo-gmail-png-file-gmail-icon-svg-wikimedia-commons-0.png" Width="60px" Height="60px"></asp:Image></a>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="abc@gmail.com"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;
                       <asp:Image runat="server" ImageUrl="~/imgs/a25f4f58938bbe61357ebca42d23866f.png" Width="52px" Height="51px"></asp:Image>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Bank2020"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;
                       <asp:Image runat="server" ImageUrl="~/imgs/whatsapp-512.png" Width="49px" Height="44px"></asp:Image>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="123456789"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image runat="server" ImageUrl="~/imgs/facebook-new.png" Width="62px" Height="57px"></asp:Image>
                        </td>
                        <td>
                            <asp:Label runat="server" Text="Bank2020"></asp:Label>
                        </td>
                    </tr>


                </table>
            </div>


        </div>
    </div>
</asp:Content>
