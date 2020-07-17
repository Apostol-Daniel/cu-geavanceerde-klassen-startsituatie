using GeavanceerdeKlassen.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeavanceerdeKlassen.Lib
{
    public class Fiets : Voertuig
    {
        private bool heeftSpatborden;

        public Fiets()
        {
            aantalWielen = 2;
        }

        public bool HeeftSpatboorden 
        {
            get { return heeftSpatborden; }
            set { heeftSpatborden = value; }
        }

        public override string ToonDetails()
        {
            string welOfGeenMotor = heeftEenMotor ? "een" : "geen";
            return $"Deze fiets heeft {welOfGeenMotor} motor, heeft {aantalWielen} wielen en is van het merk {merk}";
        }
    }
}
