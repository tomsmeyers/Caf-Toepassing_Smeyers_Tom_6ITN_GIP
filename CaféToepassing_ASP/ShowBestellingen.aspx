<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowBestellingen.aspx.cs" Inherits="CaféToepassing_ASP.ShowBestellingen" %>

<!DOCTYPE html>

<html>
<head>
    <title>Show bestellingen</title>
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
                <a href="EigenaarPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Show tafels en producten</a>
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
        <a href="EigenaarPage.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Show tafels en producten</a>
    </nav>

    <form id="form1" runat="server">
        <!--Table bestelling-->
        <br />
        <br />
        <br />

        <div class="row">
            <div class="col-md-6">
                <header>
                    <h1 class="display-6">Overzicht Bestellingen</h1>
                </header>
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th scope="col"></th>
                            <th scope="col">Datum</th>
                            <th scope="col">Betaald</th>
                            <th scope="col">Tafelnummer</th>
                            <th scope="col">Emailadress</th>
                        </tr>
                    </thead>
                    <tbody>
                        <%=OpdrachtBestelling()%>
                    </tbody>
                </table>
            </div>
            <div class="col-md-6">
                <header>
                    <h1 class="display-6">Overzicht Producten in bestelling</h1>
                </header>
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th scope="col">Bestelingid</th>
                            <th scope="col">Product</th>
                            <th scope="col">Aantal</th>
                        </tr>
                    </thead>
                    <tbody>
                        <%=OpdrachtProductenInBestelling()%>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
