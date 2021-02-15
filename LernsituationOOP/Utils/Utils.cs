using LernsituationOOP.Personen;
using LernsituationOOP.Vermietung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LernsituationOOP.Utils
{
    public class Utils
    {
        private static readonly Autovermieter
            autovermieter =
                new Autovermieter("SaxCleverRent", "Dresden",
                    123456789); //Legt die Musterdaten für eine Reservierungsstelle fest

        public static string FILE_PATH_RESERVIERUNGEN =
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
            "\\reservierungen.json"; //Beinhaltet den Dateispeicherort für alle Reservierungen

        public static string FILE_PATH_MITARBEITER =
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
            "\\mitarbeiter.json"; //Beinhaltet den Dateispeicherort für alle Mitarbeiter

        /// <summary>
        /// Liste mit allen Reservierungen
        /// </summary>
        public static List<Reservierung> Reservierungen { get; set; }

        /// <summary>
        /// Liste mit allen Mitarbeitern
        /// </summary>
        public static List<Mitarbeiter> Mitarbeiter { get; set; }

        /// <summary>
        /// Einfache Rückgabe aller Reservierungsinformationen
        /// </summary>
        /// <param name="reservierung">Reservierung von der die Infos benötigt werden</param>
        /// <returns>Gibt einen String mit allen Informationen zurück</returns>
        public static string GetReservierungsInfos(Reservierung reservierung)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Vorname: " + reservierung.Kunde.Vorname);
            builder.AppendLine("Nachname: " + reservierung.Kunde.Nachname);
            builder.AppendLine("Adresse: " + reservierung.Kunde.Adresse);
            builder.AppendLine("Geburtstag: " + reservierung.Kunde.Geburtsdatum.ToString("dd. MMMM yyyy"));
            builder.AppendLine("E-Mail: " + reservierung.Kunde.Email);
            builder.AppendLine("Telefonnummer: " + reservierung.Kunde.Telefonnummer);
            builder.AppendLine("Fahrzeug: " + reservierung.Fahrzeug.Modell);
            builder.AppendLine("Zustand des Fahzeugs: " + reservierung.Fahrzeug.Zustand);
            builder.AppendLine("Reservierung: " + reservierung.Reservierung_Start.Date.ToString("dd. MMMM yyyy") +
                               " bis " + reservierung.Reservierung_Ende.Date.ToString("dd. MMMM yyyy"));
            builder.AppendLine(string.Empty);
            builder.AppendLine("Prüfungsstatus: " + reservierung.Prüfungsstatus);

            if (reservierung.Prüfungsdatum == new DateTime() || reservierung.Mitarbeiter == null)
                builder.AppendLine("Die Reservierung wurde noch von keinem Mitarbeiter Überprüft!");
            else
            {
                builder.AppendLine("Geprüft am: " + reservierung.Prüfungsdatum.Date.ToString("dd. MMMM yyyy"));
                builder.AppendLine("Geprüft von Mitarbeiter: " + reservierung.Mitarbeiter.Vorname + " " +
                                   reservierung.Mitarbeiter.Nachname);
                builder.AppendLine("Mitarbeiter ID: " + reservierung.Mitarbeiter.ID);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Einfache Abfrage von Reservierungen mit einem Status X möglich
        /// </summary>
        /// <param name="prüfungsstatus">Prüfungsstatus X</param>
        /// <returns>Gibt alle Reservierungen mit dem Prüfungsstatus X zurück</returns>
        public static List<Reservierung> ReservierungMitStatusX(params Prüfungsstatus[] prüfungsstatus)
        {
            return Reservierungen.FindAll(item => prüfungsstatus.Contains(item.Prüfungsstatus));
        }

        /// <summary>
        /// Getter für den initialisierten Autovermieter
        /// </summary>
        /// <returns>Gibt den Autovermieter zurück</returns>
        public static Autovermieter GetAutovermieter() => autovermieter;

        /// <summary>
        /// Generiert eine zufällige ID für Mitarbeiter
        /// </summary>
        /// <returns>Gibt eine zufällioge Zahl zwischen 100000 und 999999 zurück</returns>
        public static int GenerateID()
        {
            int id = new Random().Next(100000, 999999);
            if (ExsistID(id))
            {
                id = new Random().Next(100000, 999999);
            }

            return id;
        }

        public static bool ExsistID(int id)
        {
            if (Mitarbeiter != null)
                return Mitarbeiter.FindAll(mitarbeiter => mitarbeiter.ID == id).Count != 0;
            return false;
        }

        /// <summary>
        /// Einfach Passwort Ent- und Verschlüsselung
        /// </summary>
        /// <param name="input">Das zu Ent- oder Verschlüsselnde Passwort</param>
        /// <returns>Gibt das Ent- oder Verschlüsselte Passwort zurück</returns>
        public static string EncryptDecryptPassword(string input)
        {
            int seed = 234;
            StringBuilder stringBuilder_String = new StringBuilder(input);
            StringBuilder stringBuilder2_Length = new StringBuilder(input.Length);
            for (int index = 0; index < input.Length; ++index)
            {
                char ch = (char) (stringBuilder_String[index] ^ seed);
                stringBuilder2_Length.Append(ch);
            }

            return stringBuilder2_Length.ToString();
        }
    }
}