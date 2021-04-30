<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EigenaarPage.aspx.cs" Inherits="CaféToepassing_ASP.EigenaarPage" %>

<!DOCTYPE html>

<html>
<head>
    <title>EigenaarPage</title>
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
                <a href="ShowBestellingen.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Show bestellingen</a>
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
        <a href="ShowBestellingen.aspx" onclick="w3_close()" class="w3-bar-item w3-button">Show bestellingen</a>
    </nav>

    <!--Table Tafels-->
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <header>
                <h1 class="display-6">Overzicht tafels</h1>
            </header>
        </div>
        <div class="row">
            <div class="col-md-4">
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th scope="col">Tafel</th>
                            <th scope="col">Positie</th>
                        </tr>
                    </thead>
                    <tbody>
                        <%=OpdrachtTafel()%>
                    </tbody>
                </table>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <a href="AddNewTafel.aspx" class="btn btn-dark btn-block">Voeg een tafel toe</a>
            </div>
        </div>
        <!--Table Producten-->
        <header>
            <h1 class="display-6">Overzicht Producten</h1>
        </header>
        <div class="row">
            <div class="col-md-4">
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th scope="col"></th>
                            <th scope="col">Productnaam</th>
                            <th scope="col">Productprijs</th>
                        </tr>
                    </thead>
                    <tbody>
                        <%=OpdrachtProducten()%>
                    </tbody>
                </table>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <a href="AddNewProduct.aspx" class="btn btn-dark btn-block">Voeg een product toe</a>
            </div>
        </div>
    </form>
</body>
</html>
