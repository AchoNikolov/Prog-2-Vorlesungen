using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personen.Daten;

namespace Personen.Ablauf

{
    class Program
    {
        static void PersonDrucken(Person person)
        {
            // slicing Problem, Member der Unterklasse werden abgeschnitten

            if (person == null)
                throw new Exception();

            Console.Write(person.Vorname + " " + person.Nachname + " " + person.Geburtstag.ToShortDateString());
            if (person is Studierender)
            {
                // Studierender studi = person as Studierender;
                // as-Operator: Referenz als Studierender wenn Objekt Studierender ist, sonst null
                Studierender studi = (Studierender)person;
                // explizite Konvertierung: Referenz als Studierender wenn Objekt Studierender ist, sonst Ausnahme
                Console.Write(" Matrikelnummer: " + studi.Matrikelnummer);
            }
            if (person is StudentischenHilfskraft)
            {
                StudentischenHilfskraft sh = person as StudentischenHilfskraft;
                Console.WriteLine(" Arbeitsvertrag: " + sh.Arbeitsvertragsnummer);
            }
                Console.WriteLine();

        }
        static void Main()
        {
            Person p = new Person();
            p.Vorname = "Egon";
            p.Nachname = "Meier";
            p.Geburtstag = new DateTime(1990, 5, 23);
            PersonDrucken(p);

            Termin t = new Termin();
            t.Gesprächspartner = p;
            t.Uhrzeit = new DateTime(2019, 4, 10, 1, 0, 0);
            // PersonDrucken(t); // <-- geht nicht, C# ist string typisiert
            Console.WriteLine(t.Uhrzeit.ToString());
            PersonDrucken(t.Gesprächspartner);

            Studierender s = new Studierender();
            s.Vorname = "Wille";
            s.Nachname = "Schmitz";
            s.Geburtstag = new DateTime(1993, 5, 17);
            s.Matrikelnummer = "61155";
            PersonDrucken(s); // <-- Prinzip der Ezsetzbarkeit ein Studierender ist auch eine Person 

            StudentischenHilfskraft sh = new StudentischenHilfskraft();
            sh.Vorname = "Franz";
            sh.Nachname = "Sauer";
            sh.Geburtstag = new DateTime(1995, 12, 15);
            sh.Matrikelnummer = "65421";
            sh.Arbeitsvertragsnummer = "58431";
            PersonDrucken(sh);

            Console.ReadKey();
        }
    }
}
