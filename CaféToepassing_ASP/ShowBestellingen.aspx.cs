using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CaféToepassing_Domain.Business;

namespace CaféToepassing_ASP
{
    public partial class ShowBestellingen : System.Web.UI.Page
    {
        private Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                _controller = (Controller)HttpContext.Current.Session["_controller"];
            }
            else//wordt alleen uitgevoerd indien de pagina voor het eerst geladen wordt
            {
                if (HttpContext.Current.Session["_controller"] == null)
                {
                    _controller = new Controller();
                    HttpContext.Current.Session["_controller"] = _controller;
                    Response.Redirect("default.aspx");
                }
                else
                {
                    _controller = (Controller)HttpContext.Current.Session["_controller"];
                }
            }
        }
        public string OpdrachtBestelling()
        {
            List<Bestelling> OpdrachtoefeningList = _controller.GetBestellingen();

            string htmlStr = "";
            foreach (Bestelling opdrachtoefening in OpdrachtoefeningList)
            {
                htmlStr += "<tr>";
                htmlStr += "<td>" + opdrachtoefening.IdBestelling + "</td>";
                htmlStr += "<td>" + opdrachtoefening.Datum + "</td>";
                htmlStr += "<td>" + opdrachtoefening.Betaald + "</td>";
                htmlStr += "<td>" + opdrachtoefening.TafelNummer + "</td>";
                htmlStr += "<td>" + opdrachtoefening.Emailadres + "</td>";
                htmlStr += "</tr>";
            }
            return htmlStr;
        }
        public string OpdrachtProductenInBestelling()
        {
            List<ProductenInBestellenVoorEigenaar> OpdrachtoefeningList = _controller.GetAllProductenInBestelling();

            string htmlStr = "";
            foreach (ProductenInBestellenVoorEigenaar opdrachtoefening in OpdrachtoefeningList)
            {
                htmlStr += "<tr>";
                htmlStr += "<td>" + opdrachtoefening.IdBestelling + "</td>";
                htmlStr += "<td>" + opdrachtoefening.NaamProduct + "</td>";
                htmlStr += "<td>" + opdrachtoefening.Aantal + "</td>";
                htmlStr += "</tr>";
            }
            return htmlStr;
        }
    }
}