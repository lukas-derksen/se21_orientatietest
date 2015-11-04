using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class KleineZaal : Verhuur
    {        
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
