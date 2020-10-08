﻿using System;

namespace LernsituationOOP.de.tnuerk.klassen
{
    class Reservierung
    {
        public Reservierung(Fahrzeug fahrzeug, Kunde kunde, DateTime reservierung_Start, DateTime reservierung_Ende, bool geprüft = false, DateTime? prüfungsdatum = null, Mitarbeiter mitarbeiter = null)
        {
            Fahrzeug = fahrzeug;
            Kunde = kunde;
            Reservierung_Start = reservierung_Start;
            Reservierung_Ende = reservierung_Ende;
            Geprüft = geprüft;
            Prüfungsdatum = prüfungsdatum;
            Mitarbeiter = mitarbeiter;
        }

        public Fahrzeug Fahrzeug { get; set; }
        public Kunde Kunde { get; set; }

        public DateTime Reservierung_Start { get; set; }
        public DateTime Reservierung_Ende { get; set; }

        public bool Geprüft { get; set; }
        public DateTime? Prüfungsdatum { get; set; }

        public Mitarbeiter Mitarbeiter { get; set; }

    }
}
