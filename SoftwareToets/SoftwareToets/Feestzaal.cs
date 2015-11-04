using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class Feestzaal : Verhuur
    {        
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
