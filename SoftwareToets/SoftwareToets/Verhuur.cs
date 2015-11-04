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
        public int UrenVerhuurd { get; private set; }
        public decimal Bedrag { get; private set; }
        public DateTime Tijdstip { get; private set; }
        public BTWTarief BTWTarief { get; private set; }
        public decimal PrijsPerUur { get; private set; }

        //Constructor
        public Verhuur(DateTime tijdstip, int urenVerhuurd)
        {

        }

        public override string ToString()
        {
            return UrenVerhuurd + " - " Tijdstip + " - " + Bedrag;
        }
    }
}
