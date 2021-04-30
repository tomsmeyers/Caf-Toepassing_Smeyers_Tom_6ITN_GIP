using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CaféToepassing_Domain.Business;

namespace CaféToepassing_ASP
{
    public partial class EigenaarPage : System.Web.UI.Page
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
        public string OpdrachtTafel()
        {
            List<Tafel> OpdrachtoefeningList = _controller.GetTafels();

            string htmlStr = "";
            foreach (Tafel opdrachtoefening in OpdrachtoefeningList)
            {
                htmlStr += "<tr>";
                htmlStr += "<td>" + opdrachtoefening.TafelNummer + "</td>";
                htmlStr += "<td>" + opdrachtoefening.Positie + "</td>";
                htmlStr += "</tr>";
            }
            return htmlStr;
        }
        public string OpdrachtProducten()
        {
            List<Producten> OpdrachtoefeningList = _controller.getProducten();
            string htmlStr = "";
            foreach (Producten opdrachtoefening in OpdrachtoefeningList)
            {
                htmlStr += "<tr>";
                htmlStr += "<td>" + opdrachtoefening.IdProduct + "</td>";
                htmlStr += "<td>" + opdrachtoefening.ProductNaam + "</td>";
                htmlStr += "<td>" + "€" + opdrachtoefening.PrijsProduct + "</td>";
                htmlStr += "</tr>";
            }
            return htmlStr;
        }
    }
}