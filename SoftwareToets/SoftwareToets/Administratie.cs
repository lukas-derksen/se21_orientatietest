using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public class Administratie
    {
        //Properties
        public List<Verkoop> Verkopen { get; private set; }
        public List<Verhuur> Verhuringen { get; private set; }

        //Constructor
        public Administratie() 
        {
            Verkopen = new List<Verkoop>();
            Verhuringen = new List<Verhuur>();
        }

        //Methods
        public void VoegToe(Verhuur verhuur)
        {
            Verhuringen.Add(verhuur);
        }
        public void VoegToe(Verkoop verkoop)
        {
            Verkopen.Add(verkoop);
        }
    }
}
