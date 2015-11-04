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
        public decimal Bedrag { get; }
        public DateTime Tijdstip { get; protected set; }
        public abstract BTWTarief BTWTarief { get; }
        public abstract decimal PrijsPerUur { get; }

        //Constructor
        public Verhuur(DateTime tijdstip, int urenVerhuurd)
        {
            this.Tijdstip = tijdstip;
            this.UrenVerhuurd = urenVerhuurd;
        }
        public int CompareTo(IInkomsten inkomst)
        {
            if (inkomst == null) return 1;

            IInkomsten otherInkomst = inkomst as IInkomsten;
            if (otherInkomst != null)
                return this.IInkomst.CompareTo(otherInkomst.Tijdstip);
        }
        public override string ToString()
        {
            return UrenVerhuurd + " - " + Tijdstip + " - " + Bedrag;
        }
    }
}
