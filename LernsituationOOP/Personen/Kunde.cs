using System;

namespace LernsituationOOP.Personen
{
    public class Kunde : Person
    {
        public Kunde(string vorname, string nachname, DateTime geburtsdatum, string adresse, string email, long telefonnummer, int kundennummer) : base(vorname, nachname, geburtsdatum, adresse, email, telefonnummer)
        {
            KundenNummer = kundennummer;
        }

        public int KundenNummer { get; }
    }
}
