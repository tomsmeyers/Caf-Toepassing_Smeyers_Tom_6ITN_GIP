<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OverOns.aspx.cs" Inherits="CaféToepassing_ASP.OverOns" %>

<!DOCTYPE html>

<html>
<head>
    <title>About us</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <link rel="stylesheet" href="Cafétoepassing.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
    <!-- Navbar (sit on top) -->
    <div class="w3-top">
        <div class="w3-bar w3-white w3-card" id="NavigatieBar">
            <a href="StartPage.aspx" class="w3-bar-item w3-button w3-wide">Café Het Plezier</a>

            <!-- Right-sided navbar links -->
            <div class="w3-right w3-hide-small">
                <a href="MenuPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Producten</a>
                <a href="MakeBestellingPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Bestellen</a>
                <a href="OverOns.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Over Ons</a>
                <a href="EigenaarAanmeldPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Eigenaar</a>
            </div>
            <!-- Hide right-floated links on small screens and replace them with a menu icon -->

            <a href="javascript:void(0)" class="w3-bar-item w3-button w3-right w3-hide-large w3-hide-medium" onclick="w3_open()">
                <i class="fa fa-bars"></i>
            </a>
        </div>
    </div>

    <!-- Sidebar on small screens when clicking the menu icon -->
    <nav class="w3-sidebar w3-bar-block w3-black w3-card w3-animate-left w3-hide-medium w3-hide-large" style="display: none" id="mySidebar">
        <a href="javascript:void(0)" onclick="w3_close()" class="w3-bar-item w3-button w3-large w3-padding-16">Close ×</a>
        <a href="MenuPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Producten</a>
        <a href="MakeBestellingPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Bestellen</a>
        <a href="OverOns.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Over Ons</a>
        <a href="EigenaarAanmeldPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Eigenaar</a>
    </nav>

    <form id="form1" runat="server">
        <div class="w3-container" id="about">
            <div class="w3-content" style="max-width: 700px">
                <h5 class="w3-center w3-padding-64"><span class="w3-tag w3-wide">OVER ONS</span></h5>
                <p>Hallo, ik ben Tom Smeyers en oprichter van café Het Plezier en deze site, ons café is ontstaan omdat er in Lichtaart niet veel cafés aanwezig waren en wij de mensen toch wilden laten genieten van hun favoriete drankje op een gezellig terrasje. Zeker langskomen du!</p>
                <p>Op deze site kan u ons menu vinden, en kan u ook een bestelling plaatsen voor als u op ons fantastisch terras zit.</p>
                <div class="w3-panel w3-leftbar w3-light-grey">
                    <p><i>"Ik heb een tooglief, ze is blond en hangt aan mijn lippen. En 0, wat kan onze liefde zo heerlijk schuimen"</i></p>
                    <p></p>
                </div>
                <img src="/Pictures/Café2.0.jpg" style="width: 100%; max-width: 1000px" class="w3-margin-top">
                <p><strong>Opening hours:</strong> everyday from 6pm to 3am.</p>
                <p><strong>Address:</strong> 15 Beer street, 2460, Lichtaart</p>
            </div>
        </div>
    </form>
</body>
</html>
