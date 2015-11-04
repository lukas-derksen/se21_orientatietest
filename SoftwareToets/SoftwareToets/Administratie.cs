using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class Administratie
    {
        //Fields
        private List<Verkoop> verkopen;
        private List<Verhuur> verhuringen;

        //Constructor
        public Administratie() 
        {
            verkopen = new List<Verkoop>();
            verhuringen = new List<Verhuur>();
        }

        //Methods
        public void VoegToe(Verhuur verhuur)
        {

        }
        public void VoegToe(Verkoop verkoop)
        {

        }
    }
}
