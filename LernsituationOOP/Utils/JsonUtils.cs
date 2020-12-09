using LernsituationOOP.Personen;
using LernsituationOOP.Vermietung;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace LernsituationOOP.Utils
{
    public class JsonUtils
    {
        /// <summary>Speichert das gegebene Objekt (in diesem Fall ein String) am gegebenem Dateipfad ab</summary>
        /// <param name="filePath">Dateipfad</param>
        /// <param name="objectToJson">Text der zu speichern ist</param>
        private static void SerializeObjectToFile(string filePath, object objectToJson)
        {
            string jsonString = JsonConvert.SerializeObject(objectToJson);
            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>Liest den Inhalt (Text) aus der angegebenen Datei aus</summary>
        /// <param name="filePath">Dateipfad</param>
        /// <returns>Gibt den Erfolg des Auslesen zurück</returns>
        private static string ReadTextFromFile(string filePath) => !File.Exists(filePath) ? "" : File.ReadAllText(filePath);

        /// <summary>Speichert alle Reservierungen</summary>
        /// <returns>Gibt den Erfolg des Speichern zurück</returns>
        public static bool SaveReservierungen()
        {
            SerializeObjectToFile(Utils.FILE_PATH_RESERVIERUNGEN, Utils.Reservierungen);
            return true;
        }

        /// <summary>Speichert alle Mitarbeiter</summary>
        /// <returns>Gibt den Erfolg des Speichern zurück</returns>
        public static bool SaveMitarbeiter()
        {
            SerializeObjectToFile(Utils.FILE_PATH_MITARBEITER, Utils.Mitarbeiter);
            return true;
        }

        /// <summary>Liest alle Reservierungen aus der Datei aus</summary>
        /// <returns>Gibt den Erfolg des Auslesen zurück</returns>
        public static bool LoadReservierungen()
        {
            List<Reservierung> reservierungen = JsonConvert.DeserializeObject<List<Reservierung>>(ReadTextFromFile(Utils.FILE_PATH_RESERVIERUNGEN));
            Utils.Reservierungen = reservierungen ?? new List<Reservierung>();
            return true;
        }

        /// <summary>Liest alle Reservierungen aus der Datei aus</summary>
        /// <returns>Gibt den Erfolg des Auslesen zurück</returns>
        public static bool LoadReservierungen1()
        {
            List<Reservierung> reservierungen = JsonConvert.DeserializeObject<List<Reservierung>>(ReadTextFromFile(Utils.FILE_PATH_RESERVIERUNGEN));
            Utils.Reservierungen = reservierungen ?? new List<Reservierung>();
            return true;
        }

        /// <summary>Liest alle Mitarbeiter aus der Datei aus</summary>
        /// <returns>Gibt den Erfolg des Auslesen zurück</returns>
        public static bool LoadMitarbeiter()
        {
            List<Mitarbeiter> mitarbeiter = JsonConvert.DeserializeObject<List<Mitarbeiter>>(ReadTextFromFile(Utils.FILE_PATH_MITARBEITER));
            Utils.Mitarbeiter = mitarbeiter ?? new List<Mitarbeiter>();
            return true;
        }
    }
}