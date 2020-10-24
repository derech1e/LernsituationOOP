using System;

namespace LernsituationOOP.de.tnuerk.klassen
{
    class Kunde : Person
    {
        public Kunde(string vorname, string nachname, DateTime geburtsdatum, string adresse, string email, long telefonnummer, int kundennummer) : base(vorname, nachname, geburtsdatum, adresse, email, telefonnummer)
        {
            KundenNummer = kundennummer;
        }

        public int KundenNummer { get; }
    }
}
