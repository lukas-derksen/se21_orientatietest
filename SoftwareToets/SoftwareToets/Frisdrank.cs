using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class Frisdrank : Verkoop
    {

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
