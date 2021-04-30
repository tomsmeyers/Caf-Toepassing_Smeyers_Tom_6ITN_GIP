using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CaféToepassing_Domain.Business;

namespace CaféToepassing_ASP
{
    public partial class BestelPage : System.Web.UI.Page
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
                fillGeneralList();
            }
        }
        private void fillGeneralList()
        {
            List<Producten> AlleItems = _controller.getProducten();
            lbxAllItemsList.DataSource = AlleItems;
            lbxAllItemsList.DataBind();
            lbxAllItemsList.Rows = lbxAllItemsList.Items.Count;
        }
        private void fillPersonalList()
        {
            List<ProductenInBestelling> JouwItems = _controller.GetProductenInBestelling();
            lbxJouwItems.DataSource = JouwItems;
            lbxJouwItems.DataBind();
            lbxJouwItems.Rows = lbxAllItemsList.Items.Count;
        }
        protected void VoegProductToe_Click(object sender, EventArgs e)
        {
            _controller.addProductenInBestelling(lbxAllItemsList.SelectedIndex, Convert.ToInt32(txtAantal.Text));
            fillGeneralList();
            fillPersonalList();

        }
        protected void ButtonAfrekenen_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Uw bestelling is gemaakt en zal aan uw tafel geleverd worden!')</script>");
            Response.Redirect("MakeBestellingPage.aspx");
        }
    }
}