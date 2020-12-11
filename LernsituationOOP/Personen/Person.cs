using LernsituationOOP.Utils.Validation;
using System;

namespace LernsituationOOP.Personen
{
    public class Person
    {
        private string _Email;

        /// <summary>
        /// Basis-Konstruktor für neue Kunden und Mitarbeiter die allen Daten behinhaltet, die für eine Person benötigt werden.
        /// </summary>
        /// <param name="vorname">Vorname der Person</param>
        /// <param name="nachname">Nachname der Person</param>
        /// <param name="geburtsdatum">Geburtsdatum der Person</param>
        /// <param name="adresse">Adresse der Person</param>
        /// <param name="email">E-Mail der Person</param>
        /// <param name="telefonnummer">Telefonnummer der Person</param>
        public Person(string vorname, string nachname, DateTime geburtsdatum, string adresse, string email, long telefonnummer)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Adresse = adresse;
            _Email = email;
            Telefonnummer = telefonnummer;
        }

        /// <summary>
        /// Basis-Konstruktor für neue Kunden und Mitarbeiter die allen Daten behinhaltet, die für eine Person benötigt werden.
        /// </summary>
        /// <param name="vorname">Vorname der Person</param>
        /// <param name="nachname">Nachname der Person</param>
        /// <param name="geburtsdatum">Geburtsdatum der Person</param>
        /// <param name="adresse">Adresse der Person</param>
        /// <param name="email">E-Mail der Person</param>
        public Person(string vorname, string nachname, DateTime geburtsdatum, string adresse, string email)
        {
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Adresse = adresse;
            _Email = email;
            Telefonnummer = -1L;
        }

        /// <summary>
        /// Basis-Konstruktor für neue Kunden und Mitarbeiter die allen Daten behinhaltet, die für eine Person benötigt werden.
        /// </summary>
        /// <param name="vorname">Vorname der Person</param>
        /// <param name="nachname">Nachname der Person</param>
        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        public string Vorname { get; }

        public string Nachname { get; }

        public DateTime Geburtsdatum { get; }

        public string Adresse { get; }

        public string Email
        {
            get => _Email;
            set => _Email = new StringValidation(value).IsEmail().ValidateAND() ? value : throw new FormatException("Der String enthält kein gültiges E-Mail Format!"); //Überprüft ob eine gültige E-Mail vorliegt.
        }

        public long Telefonnummer { get; }
    }
}
