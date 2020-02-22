<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Verto_Test._Test" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="orbit" role="region" aria-label="Favorite Space Pictures" data-orbit data-options="animInFromLeft:fade-in; animInFromRight:fade-in; animOutToLeft:fade-out; animOutToRight:fade-out;">
        <ul class="orbit-container">
            <button class="orbit-previous"><span class="show-for-sr">Previous Slide</span>&#9664;&#xFE0E;</button>
            <button class="orbit-next"><span class="show-for-sr">Next Slide</span>&#9654;&#xFE0E;</button>
            <li class="is-active orbit-slide">
                <img class="orbit-image" src="assets\\img\\orbit\\space1.jpg" alt="Space">
                <figcaption class="orbit-caption">Space, the final frontier.</figcaption>
            </li>
            <li class="orbit-slide">
                <img class="orbit-image" src="assets\\img\\orbit\\space2.jpg" alt="Space">
                <figcaption class="orbit-caption">Lets Rocket!</figcaption>
            </li>
            <li class="orbit-slide">
                <img class="orbit-image" src="assets\\img\\orbit\\space3.jpg" alt="Space">
                <figcaption class="orbit-caption">Encapsulating</figcaption>
            </li>
            <li class="orbit-slide">
                <img class="orbit-image" src="assets\\img\\orbit\\space4.jpg" alt="Space">
                <figcaption class="orbit-caption">Outta This World</figcaption>
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
                <asp:Repeater ID="VertoRepeater" runat="server"> 
        <div class="grid-x grid-margin-x small-up-2 medium-up-2 large-up-4">
            <div class="cell">
                <h4><asp:Label ID = "txtHeader" runat = "server" /></h4>
                <img class="thumbnail" src="assets\\img\\product.jpg">
                <p><asp:Label ID = "txtContent" runat = "server" /></p>
                <a href="#" class="button expanded">New Products</a>
            </div>
            <div class="cell">
                <h4>Field Events</h4>
                <img class="thumbnail" src="assets\\img\\events.jpg">
                <p>Lorem ipsum dolor sit amert, id per dictus incermis. Eam odio modo cibo at. Purto diginissim euripidis eu mel, cu mel</p>
                <a href="#" class="button expanded">View Events</a>
            </div>
            <div class="cell">
                <h4>Latest News</h4>
                <img class="thumbnail" src="assets\\img\\news.jpg">
                <p>Lorem ipsum dolor sit amert, id per dictus incermis. Eam odio modo cibo at. Purto diginissim euripidis eu mel, cu mel</p>
                <a href="#" class="button expanded">Read Article</a>
            </div>
            <div class="cell">
                <h4>Gallery</h4>
                <img class="thumbnail" src="assets\\img\\gallery.jpg">
                <p>Lorem ipsum dolor sit amert, id per dictus incermis. Eam odio modo cibo at. Purto diginissim euripidis eu mel, cu mel</p>
                <a href="#" class="button expanded">View Gallery</a>
            </div>
        </div>
                    </asp:Repeater>

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
                <p>Lorem ipsum dolor sit amert, id per dictus incermis. Eam odio modo cibo at. Purto diginissim euripidis eu mel, cu mel</p>
                 </div>
            </div>
            <div class="cell">
                <div style="background-color:white">
                <img src="assets\\img\\events.jpg">
                <p>Lorem ipsum dolor sit amert, id per dictus incermis. Eam odio modo cibo at. Purto diginissim euripidis eu mel, cu mel</p>
                </div>
                <a href="#" class="button expanded">View All Offers</a>
            </div>
            <div class="cell">
             <div style="background-color:white">
                <img src="assets\\img\\news.jpg">
                <p>Lorem ipsum dolor sit amert, id per dictus incermis. Eam odio modo cibo at. Purto diginissim euripidis eu mel, cu mel</p>
                 </div>
            </div>
        </div>
            </div>

         <div class="text-center">
            <h4>Product Categories</h4>
            <hr>
        </div>
    </article>

    <script src="https://code.jquery.com/jquery-2.1.4.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/foundation/6.4.3/js/foundation.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/motion-ui/1.2.3/motion-ui.min.js"></script>
    <script>
        $(document).foundation();
    </script>

</asp:Content>

