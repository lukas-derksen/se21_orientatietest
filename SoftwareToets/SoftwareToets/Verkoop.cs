using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public abstract class Verkoop : IInkomsten
    {
        //Properties
        public int Aantal { get; private set; }
        public decimal Bedrag { get; private set; }
        public DateTime Tijdstip { get; private set; }
        public BTWTarief BTWTArief { get; private set; }
        public decimal Prijs { get; private set; }

        //Constructor
        public Verkoop(int aantal)
        {

        }

        public override string ToString()
        {
            return Aantal + " - " + "EU" + Bedrag + " - " + Tijstip;
        }
    }
}
