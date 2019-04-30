using System;

namespace Fahrzeuge.Daten

{
    // keine Oberklasse angegeben: Klasse "Objekt" (Grunddatentyp "object") ist Obeklasse

    class Fahrzeug
    {
        private int _anzahlRäder;
        // protected int _anzahlRäder;
        // protected: zugreifbar für Unterklassen, aber nicht für andere Klassen
        // nie auf Felder!!!

        public int AnzahlRäder
        {
            get { return _anzahlRäder; }
            protected set
            {
                if (value < 1)
                    throw new Exception();

                _anzahlRäder = value;
            }
        }

        public Fahrzeug(int anzahlRäder)
        {
            if (anzahlRäder < 1)
                throw new Exception();

            AnzahlRäder = anzahlRäder;
        }

        public Fahrzeug()
        {
            _anzahlRäder = 4;
        }
        //druckbare Darstellung des Objektinhalts

        public string Darstellung()
        {
            return " Räder: " + _anzahlRäder.ToString();
        }

        //
        public override string ToString()
        {
            return base.ToString();
        }

        // Umwalndlung Obejktinhalt in Zahl
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //Wertvergleich (== - Referenzvergleich)
        public override bool Equals(object obj)
        {
            // Equals wirft keine Ausnahmen - niemals explizite Konvertierung verwenden
            Fahrzeug f = obj as Fahrzeug;
            return f != null && _anzahlRäder.Equals(f._anzahlRäder);
        }
    }

    class Auto : Fahrzeug
    {
        private string _kennzeichen;

        public string Kennzeichen { get { return _kennzeichen; } }

        // base: REferenz auf das eigene Objekt, aber als eines der Oberklasse
        // Zugriff auf verdeckte/ uberschreibene Methoden
        // Zugriff auf Konstruktor der Obeerklasse
        // Chaining: Aufruf der Methode der Oberklasse durch analoge Methode der Unterklasse
        // Konstruktorchaining gibt es immer - fehlt "base" im Konstruktor, wird immer der Standartkonstruktor der Oberklasse erfunden

        public Auto(int anzahlRäder, string kennzeichen): base(anzahlRäder)
        { 

            if (String.IsNullOrWhiteSpace(kennzeichen))
                throw new Exception();
            _kennzeichen = kennzeichen;
        }

        public override string ToString()
        {
            return base.ToString() + " Kennzeichen: " + _kennzeichen;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ _kennzeichen.GetHashCode();
        }

        // ^ - bitweise XOR
        // 1011

        // 1101
        // ----
        //01
    }

}