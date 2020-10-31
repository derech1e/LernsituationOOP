using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LernsituationOOP.de.tnuerk.utils
{
    class Utils
    {
        private static readonly Autovermieter autovermieter = new Autovermieter("Mustervermietung 24", "Dresden", 123456789);
        public static string FILE_PATH_RESERVIERUNGEN = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\reservierungen.json";
        public static string FILE_PATH_MITARBEITER = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\mitarbeiter.json";

        public static List<Reservierung> Reservierungen { get; set; }

        public static List<Mitarbeiter> Mitarbeiter { get; set; }

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
            builder.AppendLine("Reservierung: " + reservierung.Reservierung_Start.Date.ToString("dd. MMMM yyyy") + " bis " + reservierung.Reservierung_Ende.Date.ToString("dd. MMMM yyyy"));
            builder.AppendLine(string.Empty);
            builder.AppendLine("Prüfungsstatus: " + reservierung.Prüfungsstatus);
            if (reservierung.Prüfungsdatum == new DateTime() || reservierung.Mitarbeiter == null)
                builder.AppendLine("Die Reservierung wurde noch von keinem Mitarbeiter Überprüft!");
            else
            {
                builder.AppendLine("Geprüft am: " + reservierung.Prüfungsdatum.Value.Date.ToString("dd. MMMM yyyy"));
                builder.AppendLine("Geprüft von Mitarbeiter: " + reservierung.Mitarbeiter.Vorname + " " + reservierung.Mitarbeiter.Nachname);
                builder.AppendLine("Mitarbeiter ID: " + reservierung.Mitarbeiter.ID);
            }
            return builder.ToString();
        }

        public static List<Reservierung> ReservierungMitStatusX(params Prüfungsstatus[] prüfungsstatus)
        {
            return Reservierungen.FindAll(item => prüfungsstatus.Contains(item.Prüfungsstatus));
        }

        public static Autovermieter GetAutovermieter() => Utils.autovermieter;

        public static int generateID() => new Random().Next(100000, 999999);

        public static string EncryptDecryptPassword(string input)
        {
            int num = 234;
            StringBuilder stringBuilder1 = new StringBuilder(input);
            StringBuilder stringBuilder2 = new StringBuilder(input.Length);
            for (int index = 0; index < input.Length; ++index)
            {
                char ch = (char)(stringBuilder1[index] ^ num);
                stringBuilder2.Append(ch);
            }
            return stringBuilder2.ToString();
        }
    }
}
