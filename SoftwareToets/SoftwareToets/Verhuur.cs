using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public abstract class Verhuur : IInkomsten
    {
        //Properties
        public int UrenVerhuurd { get; protected set; }
        public decimal Bedrag { get; protected set; }
        public DateTime Tijdstip { get; protected set; }
        public abstract BTWTarief BTWTarief { get; }
        public abstract decimal PrijsPerUur { get; }

        //Constructor
        public Verhuur(DateTime tijdstip, int urenVerhuurd)
        {
            this.Tijdstip = tijdstip;
            this.UrenVerhuurd = urenVerhuurd;
        }

        public override string ToString()
        {
            return UrenVerhuurd + " - " + Tijdstip + " - " + Bedrag;
        }
    }
}
