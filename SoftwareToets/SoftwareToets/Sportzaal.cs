using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class Sportzaal : Verhuur
    {
        //Properties
        public override BTWTarief BTWTarief { get { return 0; } }
        public override decimal PrijsPerUur { get { return 0; } }

        //Constructor
        public Sportzaal(DateTime tijdstip, int urenverhuurd)
            : base(tijdstip, urenverhuurd)
        {
            
        }
        public override string ToString()
        {
            return "Sportzaal - " + base.ToString();
        }
    }
}
