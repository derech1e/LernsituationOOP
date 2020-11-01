using System;

namespace LernsituationOOP.Personen
{
    public class Mitarbeiter : Person
    {
        public Mitarbeiter(string vorname, string nachname, string adresse, DateTime geburtsdatum, string email, int id, string passwort) : base(vorname, nachname, geburtsdatum, adresse, email)
        {
            ID = id;
            Passwort = passwort;
        }

        public int ID { get; }

        public string Passwort { get; set; }
    }
}
