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
        public List<IInkomsten> Overzicht(DateTime van, DateTime tot)
        {
            List<IInkomsten> overzicht = new List<IInkomsten>();
            foreach (Verkoop a in Verkopen)
            {
                if (a.Tijdstip > van && a.Tijdstip < tot)
                {
                    overzicht.Add((IInkomsten)a);
                }
            }
            foreach (Verhuur a in Verhuringen)
            {
                if (a.Tijdstip > van && a.Tijdstip < tot)
                {
                    overzicht.Add((IInkomsten)a);
                }
            }

            overzicht.Sort();
            return null;
        }
        public List<IInkomsten> Overzicht(BTWTarief tarief)
        {
            return null;
        }
    }
}
