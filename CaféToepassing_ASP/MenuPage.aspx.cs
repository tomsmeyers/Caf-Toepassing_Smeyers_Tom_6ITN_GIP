using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CaféToepassing_Domain.Business;

namespace CaféToepassing_ASP
{
    public partial class MenuPage : System.Web.UI.Page
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
        public string OpdrachtProducten()
        {
            List<Producten> OpdrachtoefeningList = _controller.getProducten();
            string htmlStr = "";
            foreach (Producten opdrachtoefening in OpdrachtoefeningList)
            {
                htmlStr += "<tr>";
                htmlStr += "<td>" + opdrachtoefening.IdProduct + "</td>";
                htmlStr += "<td>" + opdrachtoefening.ProductNaam + "</td>";
                htmlStr += "<td>" + "€" +Math.Round(opdrachtoefening.PrijsProduct,2) + "</td>";
                htmlStr += "</tr>";
            }
            return htmlStr;
        }
    }
}