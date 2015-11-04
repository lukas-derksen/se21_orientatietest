using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class Sportzaal
    {
        //Properties
        readonly BTWTarief BTWTarief;
        readonly decimal PrijsPerUur;
        
        //Constructor
        public Sportzaal(DateTime tijdstip, int urenverhuurd)
        {

        }
        public override string ToString()
        {
            return "Sportzaal - " + base.ToString();
        }
    }
}
