using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrzeuge.Daten;

namespace Fahrzeuge.Ablauf
{
    class Program
    {
        static void Main()
        {
            Fahrzeug f = new Fahrzeug(2);
            Console.WriteLine(f.ToString());

            Auto a = new Auto(4, "KA-RL 1715");
            Console.WriteLine(a); 
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(a.Equals(new Auto(4, "KA-RL 1715")));
            Console.WriteLine(a == (new Auto(4, "KA-RL 1715")));

        }
    }
}
