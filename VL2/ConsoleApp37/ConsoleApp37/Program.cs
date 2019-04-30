using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AufDenHundGekommen.Daten;

namespace AufDenHundGekommen.Ablauf
{
    class Program
    {
        // ref: Werttyp änderbar
        // out: zusätzlicher Rückgabewert

        static void Adeln(ref Hund hund)
        {
            hund.Name = hund.Name + " von Knochenbrug";

        }
        static void Main()
        {
            Hund hund1;
            hund1 = new Hund("Waldi");
            Console.WriteLine("Hund 1: " + hund1.Name);

            Console.WriteLine();

            Hund hund2 = hund1;
            Console.WriteLine("Hund 1: " + hund1.Name);
            Console.WriteLine("Hund 2: " + hund1.Name);

            Console.WriteLine();

            hund2.Name = "Fifi";
            Console.WriteLine("Hund 1: " + hund1.Name);
            Console.WriteLine("Hund 2: " + hund1.Name);

            Adeln(ref hund2);
            Console.WriteLine("Hund 1: " + hund1.Name);
            Console.WriteLine("Hund 2: " + hund1.Name);

            Console.WriteLine("\n----\n");

            Hund waldi = new Hund("Waldi");
            Hütte hütte1 = new Hütte(waldi);

            // Referenzkopie
            // alte Hütte, alter Hund
            Hütte hütte2 = hütte1;

            //flache Kopie
            // neue Hütte, alter Hund
            Hütte hütte3 = new Hütte(hütte1.Hund);

            //tiefe Kopie
            //neue Hütte, neuer Hund
            Hütte hütte4 = new Hütte(new Hund(hütte1.Hund));

            Console.WriteLine(hütte1.Hund.Name);
            Console.WriteLine(hütte2.Hund.Name);
            Console.WriteLine(hütte3.Hund.Name);
            Console.WriteLine(hütte4.Hund.Name);

            Console.WriteLine();

            hütte1.Hund.Name = "Fifi";

            Console.WriteLine(hütte1.Hund.Name);
            Console.WriteLine(hütte2.Hund.Name);
            Console.WriteLine(hütte3.Hund.Name);
            Console.WriteLine(hütte4.Hund.Name);

            Console.ReadKey();
            
           
        }
    }
}
