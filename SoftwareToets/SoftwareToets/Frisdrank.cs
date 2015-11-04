using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class Frisdrank : Verkoop
    {
        //Properties
        public override BTWTarief BTWTArief { get { return 0; } }
        public override decimal Prijs { get { return 0; } }

        //Constructor
        public Frisdrank(int aantal)
            : base(aantal)
        {
            
        }

        public override string ToString()
        {
            return "Frisdrank - " + base.ToString();
        }

    }
}
