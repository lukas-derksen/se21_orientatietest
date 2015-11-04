using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class WarmeDrank : Verkoop
    {
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
