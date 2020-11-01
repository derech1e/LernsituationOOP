﻿using LernsituationOOP.Personen;
using LernsituationOOP.Vermietung;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace LernsituationOOP.Utils
{
    public class JsonUtils
    {
        /// <summary>Speichert das gegebene Objekt am gegebenem Dateipfad</summary>
        /// <param name="filePath">Dateipfad</param>
        /// <param name="textToSave">Text der zu speichern ist</param>
        private static void SaveJsonToFile(string filePath, object textToSave)
        {
            string contents = JsonConvert.SerializeObject(textToSave);
            File.WriteAllText(filePath, contents);
        }

        /// <summary>Liest den Json aus der angegebenen Datei aus</summary>
        /// <param name="filePath">Dateipfad</param>
        /// <returns>Gibt den Erfolg der Auslesen zurück</returns>
        private static string LoadJsonFromFile(string filePath) => !File.Exists(filePath) ? "" : File.ReadAllText(filePath);

        /// <summary>Speichert alle Reservierungen</summary>
        /// <returns>Gibt den Erfolg der Speicherung zurück</returns>
        public static bool SaveReservierungen()
        {
            JsonUtils.SaveJsonToFile(Utils.FILE_PATH_RESERVIERUNGEN, Utils.Reservierungen);
            return true;
        }

        /// <summary>Speichert alle Mitarbeiter</summary>
        /// <returns>Gibt den Erfolg der Speicherung zurück</returns>
        public static bool SaveMitarbeiter()
        {
            JsonUtils.SaveJsonToFile(Utils.FILE_PATH_MITARBEITER, Utils.Mitarbeiter);
            return true;
        }

        /// <summary>Liest alle Reservierungen aus der Datei aus</summary>
        /// <returns>Gibt den Erfolg der Auslesen zurück</returns>
        public static bool LoadReservierungen()
        {
            List<Reservierung> reservierungen = JsonConvert.DeserializeObject<List<Reservierung>>(LoadJsonFromFile(Utils.FILE_PATH_RESERVIERUNGEN));
            Utils.Reservierungen = reservierungen ?? new List<Reservierung>();
            return true;
        }

        /// <summary>Liest alle Reservierungen aus der Datei aus</summary>
        /// <returns>Gibt den Erfolg der Auslesen zurück</returns>
        public static bool LoadReservierungen1()
        {
            List<Reservierung> reservierungen = JsonConvert.DeserializeObject<List<Reservierung>>(LoadJsonFromFile(Utils.FILE_PATH_RESERVIERUNGEN));
            Utils.Reservierungen = reservierungen ?? new List<Reservierung>();
            return true;
        }

        /// <summary>Liest alle Mitarbeiter aus der Datei aus</summary>
        /// <returns>Gibt den Erfolg der Auslesen zurück</returns>
        public static bool LoadMitarbeiter()
        {
            List<Mitarbeiter> mitarbeiter = JsonConvert.DeserializeObject<List<Mitarbeiter>>(LoadJsonFromFile(Utils.FILE_PATH_MITARBEITER));
            Utils.Mitarbeiter = mitarbeiter ?? new List<Mitarbeiter>();
            return true;
        }
    }
}