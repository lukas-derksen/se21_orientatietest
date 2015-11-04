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
        public int Aantal { get; protected set; }
        public decimal Bedrag { get; protected set; }
        public DateTime Tijdstip { get; protected set; }
        public abstract BTWTarief BTWTArief { get; }
        public abstract decimal Prijs { get; }

        //Constructor
        public Verkoop(int aantal)
        {
            this.Aantal = aantal;
        }

        public override string ToString()
        {
            return Aantal + " - " + "EU" + Bedrag + " - " + Tijdstip;
        }
    }
}
