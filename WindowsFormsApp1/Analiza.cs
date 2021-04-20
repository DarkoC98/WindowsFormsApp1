using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Analiza
    {
        private string ime;
        private int prioritet;
        private string tip;
        private double cena;

        public string Ime { get => ime; set => ime = value; }
        public int Prioritet { get => prioritet; set => prioritet = value; }
        public string Tip { get => tip; set => tip = value; }
        public double Cena { get => cena; set => cena = value; }

        public override string ToString()
        {
            return "Pacijent: " + this.ime + " je obavio analize: " + this.tip + " sa prioritetom: " + this.prioritet + " Cena: " ;
        }
    }
}
