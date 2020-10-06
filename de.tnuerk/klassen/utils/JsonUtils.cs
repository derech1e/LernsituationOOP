using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernsituationOOP.de.tnuerk.klassen.utils
{
    class JsonUtils
    {
        private static List<Reservierung> reservierungen = new List<Reservierung>();

        public static void reservierungenSpeichern()
        {
        }

        public static void reserveringenLaden()
        {

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
