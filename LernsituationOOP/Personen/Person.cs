using System;

namespace LernsituationOOP.Personen
{
    public class Person
    {
        private string _Email;

        public Person(string vorname, string nachname, DateTime geburtsdatum, string adresse, string email, long telefonnummer)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Adresse = adresse;
            _Email = email;
            Telefonnummer = telefonnummer;
        }

        public Person(string vorname, string nachname, DateTime geburtsdatum, string adresse, string email)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Adresse = adresse;
            _Email = email;
            Telefonnummer = -1L;
        }

        public string Vorname { get; }

        public string Nachname { get; }

        public DateTime Geburtsdatum { get; }

        public string Adresse { get; }

        public string Email
        {
            get => _Email;
            set => _Email = ValidationUtils.IsEmailValid(value, false) ? value : throw new FormatException("E-Mail hat ein Falsches Format!");
        }

        public long Telefonnummer { get; }
    }
}
