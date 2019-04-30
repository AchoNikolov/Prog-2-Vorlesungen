using System;
using AufDenHundGekommen.Ablauf;

namespace AufDenHundGekommen.Daten
{
    // Werttypen :      Strukturen, Grunddatentypen, Aufzählungen (enums)
    // Referenztypen:   Klassen, Arrays, (string)
    class Hund
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception();

                _name = value;
            }
        }

        // Methodenüberladung
        // gleicher Bezeichner, verschiedene Parameterlisten
        // - Anzahl
        // - Typ
        // - Wert-/Referenzparameter
        // nicht:
        // - Rückgabewert
        // - Bezeichner der Parameter
        // - ref/out

        public Hund(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new Exception();

            _name = name;

        }


        // Standartkonstruktor (leere Parameterliste)

        public Hund()
        {
            _name = "(namenlos)";
        }

        // Kopierkonstruktor

        public Hund(Hund original)
        {
            if (original == null)
                throw new Exception();

            _name = original._name;
        }

        //Kopiermethode

        public Hund Kopie()
        {
            return new Hund(this._name);
        }

        //Destruktor
        ~Hund()
        {

        }
    }

    class Hütte
    {
        private Hund _hund;

        public Hund Hund
        {
            get { return _hund; }
            set { _hund = value; }
        }
        public Hütte(Hund hund)
        {
            _hund = hund;
        }
    }
   
}