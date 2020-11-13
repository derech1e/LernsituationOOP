using System;

namespace LernsituationOOP.Personen
{
    public class Mitarbeiter : Person
    {
        /// <summary>
        /// Konstruktor mit allen Daten die für einen neuen Mitarbeiter benötigt werden.
        /// </summary>
        /// <param name="vorname">Vorname des Mitarbeiters</param>
        /// <param name="nachname">Nachname des Mitarbeiters</param>
        /// <param name="adresse">Adresse des Mitarbeiters</param>
        /// <param name="geburtsdatum">Geburtsdatum des Mitarbeiters</param>
        /// <param name="email">E-Mail des Mitarbeiters</param>
        /// <param name="id">ID des Mitarbeiters</param>
        /// <param name="passwort">Passwort des Mitarbeiters</param>
        public Mitarbeiter(string vorname, string nachname, string adresse, DateTime geburtsdatum, string email, int id, string passwort) : base(vorname, nachname, geburtsdatum, adresse, email)
        {
            ID = id;
            Passwort = passwort;
        }

        public int ID { get; }

        public string Passwort { get; set; }
    }
}
