using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféToepassing_Domain.Business
{
    public class Producten
    {
        //velden
        private int _idProducten;
        private string _productNaam;
        private double _prijsProduct;

        //eigenschappen
        public int IdProduct
        {
            get { return _idProducten; }
        }
        public string ProductNaam
        {
            get { return _productNaam; }
            set { _productNaam = value; }
        }
        public double PrijsProduct
        {
            get { return _prijsProduct; }
            set { _prijsProduct = value; }
        }

        //constructor
        public Producten(int idProduct, string productnaam, double prijsproduct)
        {
            _idProducten = idProduct;
            _productNaam = productnaam;
            _prijsProduct = prijsproduct;
        }
        public Producten(string productnaam, double prijsproduct)
        {
            _idProducten = 0;
            _productNaam = productnaam;
            _prijsProduct = prijsproduct;
        }
        public override string ToString()
        {
            return _idProducten + " - " + _productNaam + " € " + Math.Round(_prijsProduct,2);
        }
    }
}
