using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CaféToepassing_Domain.Business;

namespace CaféToepassing_ASP
{
    public partial class AddNewProduct : System.Web.UI.Page
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
        protected void btnVoegToe_Click(object sender, EventArgs e)
        {
            Producten product = new Producten(txtNaamProduct.Text, Convert.ToDouble(TxtPrijsProduct.Text));
            _controller.addProducten(product);
            ClearInput();
            Response.Redirect("EigenaarPage.aspx");
        }
        protected void ClearInput()
        {
            txtNaamProduct.Text = "";
            TxtPrijsProduct.Text = "";
        }
    }
}