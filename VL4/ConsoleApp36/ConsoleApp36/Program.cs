using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geräte.Daten;

namespace Geräte.Ablauf
{
    
    class Program
    {
        static void Drucken(IDruckbar g)
        {
//            if (g is ElektrischesGerät)
//              Console.WriteLine((g as ElektrischesGerät).Darstellung());
//        else
            Console.WriteLine(g.Darstellung());
            // Polymorphie (Vielgestaltigkeit)
        }

        static void Main()
        {
            Gerät g = new HandGerät();
            g.Bezeichnung = "Hammer";
            Console.WriteLine(g.Darstellung());

            ElektrischesGerät eg = new ElektrischesGerät();
            eg.Bezeichnung = "Bohmaschine";
            eg.Spannung = 230;
            Console.WriteLine(eg.Darstellung());

            Dokument d = new Dokument();
            d.Text = "Hallo Welt";

            //Prinzip der ErsetzbarkeitSlicing Problem
            Drucken(g);
            Drucken(eg);
            Drucken(d);

            Console.ReadKey();

        }
    }
}