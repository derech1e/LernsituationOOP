using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LernsituationOOP.de.tnuerk.klassen.utils
{
    class JsonUtils
    {
        private static List<Reservierung> reservierungen = new List<Reservierung>();
        private static string FILE_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "reservierungen.json";

        public static void reservierungenSpeichern()
        {
            string textToWrite = JsonConvert.SerializeObject(reservierungen);
            File.WriteAllText(FILE_PATH, textToWrite);
        }

        public static void reserveringenLaden()
        {
            var json = File.ReadAllText(FILE_PATH);
            var fileReservierungen = JsonConvert.DeserializeObject<List<Reservierung>>(json);
            reservierungen = fileReservierungen;
        }

        public static List<Reservierung> getReservierungen()
        {
            return reservierungen;
        }

        public static bool reservierungHinzufügen(Reservierung reservierung)
        {
            reservierungen.Add(reservierung);
            return true;
        }
    }
}
