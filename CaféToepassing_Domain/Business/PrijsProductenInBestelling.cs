using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféToepassing_Domain.Business
{
    public class PrijsProductenInBestelling
    {
        //velden
        private int _idBestelling;
        private double _prijs;

        //eigenschappen
        public int IdBestelling
        {
            get { return _idBestelling; }
            set { _idBestelling = value; }
        }
        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }

        //constructor
        public PrijsProductenInBestelling(int idBestelling, double prijs)
        {
            _idBestelling = idBestelling;
            _prijs = prijs;
        }
        public PrijsProductenInBestelling(double prijs)
        {
            _idBestelling = 0;
            _prijs = prijs;
        }
        public override string ToString()
        {
            return "De totaalprijs is: "+_prijs;
        }
    }
}
