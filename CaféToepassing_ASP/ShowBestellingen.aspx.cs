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
                gridBestellingen.DataSource = _controller.GetBestellingen();
                gridBestellingen.DataBind();
            }
        }
         

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataKey bestellingid = gridBestellingen.DataKeys[gridBestellingen.SelectedIndex];
           
            //List<ProductenInBestellenVoorEigenaar> OpdrachtoefeningList = _controller.GetAllProductenInBestelling();
            List<ProductenInBestellenVoorEigenaar> OpdrachtoefeningList = _controller.GetProductenInBestelling(Convert.ToInt32(bestellingid.Value));
            gridProductenInBestellingen.DataSource = OpdrachtoefeningList;
            gridProductenInBestellingen.DataBind();
        }

        protected string ButtonValue(object objType)
        {
            if (objType.ToString() == "Ja")
            {
                return "Ja";
            }
            else
            {
                return "Betalen";
            }

        }

        protected bool CheckBoxValue(object objType)
        {
            if (objType.ToString() == "Ja")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        protected bool ButtonEnabled(object objType)
        {
            if (objType.ToString() == "Ja")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        protected void Betaald_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int bestellingid = int.Parse(btn.CommandArgument);

            //controller oproepen en bij bestelling betaald op ja zetten
            _controller.UpdateBetaalstatusBestelling(bestellingid, "Ja");
            gridBestellingen.DataSource = _controller.GetBestellingen();
            gridBestellingen.DataBind();

        }

       
    }
}

