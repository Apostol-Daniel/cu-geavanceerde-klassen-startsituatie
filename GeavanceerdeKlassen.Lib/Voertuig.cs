using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeavanceerdeKlassen.Wpf
{
    public class Voertuig
    {
        private bool heeftEenMotor;
        private string merk;

        public bool HeeftEenMotor
        {
            get { return heeftEenMotor; }
            set { heeftEenMotor = value; }
        }

        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }
    }
}
