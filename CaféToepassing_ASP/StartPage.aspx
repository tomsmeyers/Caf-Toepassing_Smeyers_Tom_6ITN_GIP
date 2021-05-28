<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="CaféToepassing_ASP.StartPage" %>

<!DOCTYPE html>
<html>
<head>
    <title>StartPage</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
    <link rel="stylesheet" href="Cafétoepassing.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
    <style>
            /* Full height image header */
    body 
    {
        background-image: url("/Pictures/cafe-beginnen.jpg");
        background-size: cover;
        background-position: center;
        min-height:100%;
    }
    </style>
<body>


    <!-- Navbar (sit on top) -->
    <div class="w3-top">
        <div class="w3-bar w3-white w3-card" id="NavigatieBar">
            <a href="StartPage.aspx" class="w3-bar-item w3-button w3-wide">Café Het Plezier</a>

            <!-- Right-sided navbar links -->
            <div class="w3-right w3-hide-small">
                <a href="MenuPage.aspx" class="w3-bar-item w3-button">Producten</a>
                <a href="MakeBestellingPage.aspx"  class="w3-bar-item w3-button">Bestellen</a> 
                <a href="OverOns.aspx" class="w3-bar-item w3-button">Over Ons</a>
                <a href="EigenaarAanmeldPage.aspx" class="w3-bar-item w3-button">Eigenaar</a>
            </div>
            <!-- Hide right-floated links on small screens and replace them with a menu icon -->

            <a href="#" class="w3-bar-item w3-button w3-right w3-hide-large w3-hide-medium" onclick="w3_open()">
                <i class="fa fa-bars"></i>
            </a>
        </div>
    </div>

    <!-- Sidebar on small screens when clicking the menu icon -->
    <nav class="w3-sidebar w3-bar-block w3-black w3-card w3-animate-left w3-hide-medium w3-hide-large" style="display:none" id="mySidebar">
        <a href="javascript:void(0)" onclick="w3_close()" class="w3-bar-item w3-button w3-large w3-padding-16">Close ×</a>
        <a href="MenuPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Producten</a>
        <a href="MakeBestellingPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Bestellen</a>
        <a href="OverOns.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Over Ons</a>
        <a href="EigenaarAanmeldPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Eigenaar</a>
    </nav>
    <!-- Header with image -->
    <header class="cafefoto w3-display-container w3-animate-opacity" id="home">
        <div class="w3-display-middle w3-center">
            <span class="w3-text-white w3-hide-small" style="font-size: 100px">
                <br>
            </span>
            <span class="w3-text-white w3-hide-large w3-hide-medium" style="font-size: 60px"><b>
                <br>
            </b></span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <span>
                <br />
            </span>
            <p><a href="MenuPage.aspx" class="w3-button w3-xxlarge w3-black">Laat het menu zien</a></p>
        </div>
    </header>
    <script>
// Modal Image Gallery
// Toggle between showing and hiding the sidebar when clicking the menu icon
var mySidebar = document.getElementById("mySidebar");

function w3_open() {
  if (mySidebar.style.display === 'block') {
    mySidebar.style.display = 'none';
  } else {
    mySidebar.style.display = 'block';
  }
}

// Close the sidebar with the close button
function w3_close() {
    mySidebar.style.display = "none";
}
    </script>
</body>
</html>
