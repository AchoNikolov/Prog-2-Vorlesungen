using System;

namespace Geräte.Daten
{
    abstract class Gerät : IDruckbar //gilt automatisch für Unterklassen
    {
        public string Bezeichnung;

        // Oberklasse muss überschreiben erlauben (virtuelle Methode)

        // abstrakte Methode (automatich virtuell)
        // - ohne Anweisungen (Rumpf)

        public abstract string Darstellung();

       // gibt auch abstrakte Eigenschaften
    }

    //konkrete Klassen - davon können Objekte gebildet werden

    class ElektrischesGerät : Gerät
    {
        public int Spannung;


        // Verdeckung
        // statisches Binden - Typ der Referenz ausschlaggebend (zur Compilezeit)
        // "new" : Verdeckung ist gewollt, kein Versehen
        // public new string Darstellung()
        // {
        //     return "Bezeichnung: " + Bezeichnung + " (" + Spannung.ToString() + " V)" ;

        // }

        // überschreibung
        // dynamisches Binden - Typ des Objekts ausschlaggebend (zur Laufzeit)
        public override string Darstellung()
        {
            return "Bezeichnung: " + Bezeichnung + " (" + Spannung.ToString() + " V)";
        }
    }
        class HandGerät : Gerät
        {
             public override string Darstellung()
            {
                return "Bezeichnung: " + Bezeichnung;
            }

        }

        class Dokument : IDruckbar
        {
            public string Text;

            public string Darstellung()
            {
                return "Text: " + Text;
            }
        }
        // Problem;
        // - Klassen sind nicht durch Vererbung verbunden
        // - haben aber gemeinsame Member
        // -> Schnittstellen/Interfaces
        // - nur abstrakte Member (Methode/Eigenschaften)
        // - geben gemeinsame Member vor, helfen nicht bei der Implementierung
        interface IDruckbar
        {
            // alle Member automatisch public und abstrakt -> Schlüsselwörter nicht hinschreiben
            string Darstellung();


        }
    }

