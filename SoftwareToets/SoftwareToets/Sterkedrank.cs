using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class Sterkedrank : Verkoop
    {
        //Properties
        public override BTWTarief BTWTArief { get { return 0; } }
        public override decimal Prijs { get { return 0; } }

        //Constructor
        public Sterkedrank(int aantal) : base(aantal)
        {

        }

        public override string ToString()
        {
            return "Sterke drank - " + base.ToString();
        }
    }
}
