using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernsituationOOP.de.tnuerk.klassen
{
    class Reservierung : Fahrzeug
    {
        public Reservierung(DateTime reservierung_Start, DateTime reservierung_Ende, bool geprüft, DateTime prüfungsdatum)
        {
            Reservierung_Start = reservierung_Start;
            Reservierung_Ende = reservierung_Ende;
            Geprüft = geprüft;
            Prüfungsdatum = prüfungsdatum;
        }

        public DateTime Reservierung_Start { get; set; }
        public DateTime Reservierung_Ende { get; set; }

        public bool Geprüft { get; set; }
        public DateTime Prüfungsdatum { get; set; }

    }
}
