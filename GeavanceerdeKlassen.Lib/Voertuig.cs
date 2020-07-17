using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeavanceerdeKlassen.Wpf
{
    // adding the abstract keyword here makes it so that no instances or objects can be created using this class
    // it is used when you want to use it to inherit but to prevent making objects off of
    public class Voertuig
    {
        protected int aantalWielen = 4;

        protected bool heeftEenMotor;
        protected string merk;

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

        public virtual string ToonDetails()
        {
            string welOfGeenMotor = heeftEenMotor ? "een" : "geen";
            return $"Dit voertuig heeft {welOfGeenMotor} motorn en is van het merk {merk}";
        }
    }
}
