using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class WarmeDrank : Verkoop
    {
        //Properties
        public override BTWTarief BTWTArief {  get { return 0; } }
        public override decimal Prijs { get { return 0; } }

        //Constructor
        public WarmeDrank(int aantal) : base(aantal)
        {
            
        }

        public override string ToString()
        {
            return "Warme drank - " + base.ToString();
        }
    }
}
