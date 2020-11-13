using System;

namespace LernsituationOOP.Personen
{
    public class Kunde : Person
    {
        /// <summary>
        /// Konstruktor mit allen Daten die für einen neuen Kunden benötigt werden.
        /// </summary>
        /// <param name="vorname">Vorname des Kunden</param>
        /// <param name="nachname">Nachname des Kunden</param>
        /// <param name="geburtsdatum">Geburtsdatum des Kunden</param>
        /// <param name="adresse">Adresse mit Hausnummer des Kunden</param>
        /// <param name="email">E-Mail des Kunden</param>
        /// <param name="telefonnummer">Telefonnummer des Kunden</param>
        /// <param name="kundennummer">Kundennummer</param>
        public Kunde(string vorname, string nachname, DateTime geburtsdatum, string adresse, string email, long telefonnummer, int kundennummer) : base(vorname, nachname, geburtsdatum, adresse, email, telefonnummer)
        {
            KundenNummer = kundennummer;
        }

        public int KundenNummer { get; }
    }
}
