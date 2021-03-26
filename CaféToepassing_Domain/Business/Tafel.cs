using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféToepassing_Domain.Business
{
    public class Tafel
    {
        //velden
        private int _tafelNummer;
        private string _positie;

        //eigenschappen
        public int TafelNummer
        {
            get { return _tafelNummer; }
        }
        public string Positie
        {
            get { return _positie; }
            set { _positie = value; }
        }

        //constructor
        public Tafel(int tafelNummer, string positie)
        {
            _tafelNummer = tafelNummer;
            _positie = positie;
        }
        public Tafel(string positie)
        {
            _tafelNummer = 0;
            _positie = positie;
        }
        public override string ToString()
        {
            return "Tafel "+ _tafelNummer + " staat " + _positie;
        }
    }
}
