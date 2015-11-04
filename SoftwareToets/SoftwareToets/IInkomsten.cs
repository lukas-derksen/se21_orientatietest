using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareToets
{
    public interface IInkomsten : IComparable<IInkomsten>
    {
        
        decimal Bedrag { get; }
        BTWTarief BTWTarief { get; }
        DateTime Tijdstip { get; }

        abstract int CompareTo(IInkomsten inkomst);
    }
}
