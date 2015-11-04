using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class KleineZaal : Verhuur
    {   
        //Properties
        public override BTWTarief BTWTarief { get { return 0; } }
        public override decimal PrijsPerUur { get { return 0; } }

        //Constructor
        public KleineZaal(DateTime tijdstip, int urenverhuurd)
            : base(tijdstip, urenverhuurd)
        {
            
        }
        public override string ToString()
        {
            return "Kleine zaal - " + base.ToString();
        }
    }
}
