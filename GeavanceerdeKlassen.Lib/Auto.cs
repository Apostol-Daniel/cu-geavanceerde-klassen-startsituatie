using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeavanceerdeKlassen.Wpf
{
    public class Auto : Voertuig
    {
        private int aantalDeuren;

        public int AantalDeuren
        {
            get { return aantalDeuren; }
            set { aantalDeuren = value; }
        }

        public string ToonDetails()
        {
            return $"Deze auto heeft {aantalDeuren} deuren en {aantalWielen} wielen";
        }
    }
}
