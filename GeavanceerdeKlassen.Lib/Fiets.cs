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

        public bool HeeftSpatboorden 
        {
            get { return heeftSpatborden; }
            set { heeftSpatborden = value; }
        }
    }
}
