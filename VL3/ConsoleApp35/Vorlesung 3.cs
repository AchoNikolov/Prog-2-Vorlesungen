using System;

namespace Personen.Daten

{
    class Person
    {   
        public string Vorname;
        public string Nachname;
        public DateTime Geburtstag;
    }

    // Wiederverwendung von Klassen in neuen Klassen

    // 1. Zusammensetzung (Aggregation)
    // alte Klasse als Feld der neue Klasse

    class Termin
    {

        public Person Gesprächspartner;
        public DateTime Uhrzeit;

    }

    // 2. Vererbung (Ableitung, Spezialisierung,ist Beziehung)
    // alte Klasse wird um neue Member zur neuen Klasse erweitert

    // alte Klasse: Oberklasse (Basisklasse, Superklasse)
    // neue Klasse: Unterklasse (Subklasse, abgeleitete Klasse)
    // Vererbungshierarchie: Unterklasse ist Oberklasse einer weiteren Vererbung (usf.)
    // Vererbung: zweite Säule der Objektorientierung

    
    // ein Studierender ist eine spezielle Person mit Matrikelnummer
    class Studierender : Person
    {
        // nur neue Member angeben
        public string Matrikelnummer;
    }

    // in C#:
    // - Konstruktoren und Destruktoren werder nicht übernommen
    // - private Member in der Unterklasse nicht zugreifbar
    // - nur eine Oberklasse (Einfachvererbung)
    // - Vererbung nur fü Klassen, nicht für Strukturen
    // - es gilt das Prinzip der Ersetzbarkeit

    class StudentischenHilfskraft : Studierender
    {
        public string Arbeitsvertragsnummer;

    }

}