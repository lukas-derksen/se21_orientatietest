using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class Feestzaal : Verhuur
    {
        //Properties
        public override BTWTarief BTWTarief { get { return 0; } }
        public override decimal PrijsPerUur { get { return 0; } }

        //Constructor
        public Feestzaal(DateTime tijdstip, int urenverhuurd)
            : base(tijdstip, urenverhuurd)
        {
            
        }
        public override string ToString()
        {
            return "Feestzaal - " + base.ToString();
        }
    }
}
