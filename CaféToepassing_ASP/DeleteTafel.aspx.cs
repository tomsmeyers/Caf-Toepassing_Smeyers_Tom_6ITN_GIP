using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CaféToepassing_Domain.Business;

namespace CaféToepassing_ASP
{
    public partial class DeleteTafel : System.Web.UI.Page
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
                FillTafelList();
            }

        }
        private void FillTafelList()
        {
            List<Tafel> AlleItems = _controller.GetTafels();
            lbxTafels.DataSource = AlleItems;
            lbxTafels.DataBind();
            lbxTafels.Rows = lbxTafels.Items.Count;
        }
        protected void btnDeleteTafel_Click(object sender, EventArgs e)
        {
            //tafel nog als inactief kunnen zetten
            Response.Redirect("EigenaarPage.aspx");
        }
    }
}