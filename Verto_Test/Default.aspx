﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Verto_Test._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="orbit" role="region" aria-label="Favorite Space Pictures" data-orbit data-options="animInFromLeft:fade-in; animInFromRight:fade-in; animOutToLeft:fade-out; animOutToRight:fade-out;">
        <ul class="orbit-container">
            <button class="orbit-previous"><span class="show-for-sr">Previous Slide</span>&#9664;&#xFE0E;</button>
            <button class="orbit-next"><span class="show-for-sr">Next Slide</span>&#9654;&#xFE0E;</button>
            <li class="is-active orbit-slide">
                <img class="orbit-image" src="<asp:Literal ID = "orbit1_ImgPath" runat = "server" />" alt="Space">
                <figcaption class="orbit-caption"><asp:Label ID = "orbit1_Header" runat = "server" /></figcaption>
            </li>
            <li class="orbit-slide">
                <img class="orbit-image" src="<asp:Literal ID = "orbit2_ImgPath" runat = "server" />" alt="Space">
                <figcaption class="orbit-caption"><asp:Label ID = "orbit2_Header" runat = "server" /></figcaption>
            </li>
            <li class="orbit-slide">
                <img class="orbit-image" src="<asp:Literal ID = "orbit3_ImgPath" runat = "server" />" alt="Space">
                <figcaption class="orbit-caption"><asp:Label ID = "orbit3_Header" runat = "server" /></figcaption>
            </li>
            <li class="orbit-slide">
                <img class="orbit-image" src="<asp:Literal ID = "orbit4_ImgPath" runat = "server" />" alt="Space">
                <figcaption class="orbit-caption"><asp:Label ID = "orbit4_Header" runat = "server" /></figcaption>
            </li>
        </ul>
        <nav class="orbit-bullets">
            <button class="is-active" data-slide="0"><span class="show-for-sr">First slide details.</span><span class="show-for-sr">Current Slide</span></button>
            <button data-slide="1"><span class="show-for-sr">Second slide details.</span></button>
            <button data-slide="2"><span class="show-for-sr">Third slide details.</span></button>
            <button data-slide="3"><span class="show-for-sr">Fourth slide details.</span></button>
        </nav>
    </div>


    <article class="grid-container">
        <div class="grid-x grid-margin-x small-up-2 medium-up-2 large-up-4">
            <div class="cell">
                <h4><asp:Label ID = "product_Header" runat = "server" /></h4>
                <img class="thumbnail" src="<asp:Literal ID = "product_ImgPath" runat = "server" />">
                <p><asp:Label ID = "product_Content" runat = "server" /></p>
                <a href="#" class="button expanded">New Products</a>
            </div>
            <div class="cell">
                <h4><asp:Label ID = "event_Header" runat = "server" /></h4>
                <img class="thumbnail" src="<asp:Literal ID = "event_ImgPath" runat = "server" />">
                <p><asp:Label ID = "event_Content" runat = "server" /></p>
                <a href="#" class="button expanded">View Events</a>
            </div>
            <div class="cell">
                <h4><asp:Label ID = "news_Header" runat = "server" /></h4>
                <img class="thumbnail" src="<asp:Literal ID = "news_ImgPath" runat = "server" />">
                <p><asp:Label ID = "news_Content" runat = "server" /></p>
                <a href="#" class="button expanded">Read Article</a>
            </div>
            <div class="cell">
                <h4><asp:Label ID = "gallery_Header" runat = "server" /></h4>
                <img class="thumbnail" src="<asp:Literal ID = "gallery_ImgPath" runat = "server" />">
                <p><asp:Label ID = "gallery_Content" runat = "server" /></p>
                <a href="#" class="button expanded">View Gallery</a>
            </div>
        </div>

        <div style="background-color:#f1f1f1">
                    <hr>
        <div class="text-center">
            <h4><font color="grey">Special Offers</font></h4>
            <hr>
        </div>
        <div class="grid-x grid-margin-x small-up-2 medium-up-2 large-up-3">
            <div class="cell">
                <div style="background-color:white">
                <img src="assets\\img\\product.jpg">
                <p>Discovery WP PC</p>
                <p><b>£20 Cashback</b>.</p>
                 </div>
            </div>
            <div class="cell">
                <div style="background-color:white">
                <img src="assets\\img\\events.jpg">
                <p>Discovery WP PC</p>
                <p><b>£20 Cashback</b>.</p>
                </div>
                <a href="#" class="button expanded">View All Offers</a>
            </div>
            <div class="cell">
             <div style="background-color:white">
                <img src="assets\\img\\news.jpg">
                <p>Discovery WP PC</p>
                <p><b>£20 Cashback</b>.</p>
                 </div>
            </div>
        </div>
            </div>

         <div class="text-center">
            <h4>Product Categories</h4>
            <hr>
        </div>
    </article>
        <asp:Repeater ID="VertoRepeater" runat="server">  
    <HeaderTemplate>  
    <table style="border:1px solid #0000FF; width:500px" cellpadding="0">  
    <tr style="background-color:#FF6600; color:#000000; font-size: large; font-weight: bold;">  
    <td colspan="2">  
    <b>Comments</b>  
    </td>  
    </tr>  
    </HeaderTemplate>  
    <ItemTemplate>  
    <tr style="background-color:#EBEFF0">  
    <td>  
    <table style="background-color:#EBEFF0;border-top:1px dotted #df5015; width:500px" >  
    <tr>  
    <td >  
    Subject:  
    <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("Subject") %>' Font-Bold="true"/>  
    </td>  
    </tr>  
    </table>  
    </td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="lblComment" runat="server" Text='<%#Eval("CommentOn") %>'/>  
    </td>  
    </tr>  
    <tr>  
    <td>  
    <table style="background-color:#EBEFF0;border-top:1px dotted #df5015;border-bottom:1px solid #df5015; width:500px" >  
    <tr>  
    <td >Post By: <asp:Label ID="lblUser" runat="server" Font-Bold="true" Text='<%#Eval("UserName") %>'/></td>  
    <td >Created Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("Post_Date") %>'/></td>  
    </tr>  
    </table>  
    </td>  
    </tr>  
    <tr>  
    <td colspan="2"> </td>  
    </tr>  
    </ItemTemplate>  
    <FooterTemplate>  
    </table>  
    </FooterTemplate>  
    </asp:Repeater>  

    <script src="https://code.jquery.com/jquery-2.1.4.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/foundation/6.4.3/js/foundation.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/motion-ui/1.2.3/motion-ui.min.js"></script>
    <script>
        $(document).foundation();
    </script>

</asp:Content>
