using LernsituationOOP.Personen;
using LernsituationOOP.Utils;
using Newtonsoft.Json;
using System;

namespace LernsituationOOP.Vermietung
{
    public class Reservierung
    {
        [JsonConstructor]
        public Reservierung(Fahrzeug fahrzeug, Kunde kunde, DateTime reservierung_Start, DateTime reservierung_Ende, Prüfungsstatus prüfungsstatus = Prüfungsstatus.IN_BEARBEITUNG)
        {
            Fahrzeug = fahrzeug;
            Kunde = kunde;
            Reservierung_Start = reservierung_Start;
            Reservierung_Ende = reservierung_Ende;
            Prüfungsstatus = prüfungsstatus;
            Prüfungsdatum = new DateTime();
            Mitarbeiter = null;
        }

        public Reservierung(Fahrzeug fahrzeug, Kunde kunde, DateTime reservierung_Start, DateTime reservierung_Ende, Prüfungsstatus prüfungsstatus, DateTime prüfungsdatum, Mitarbeiter mitarbeiter)
        {
            Fahrzeug = fahrzeug;
            Kunde = kunde;
            Reservierung_Start = reservierung_Start;
            Reservierung_Ende = reservierung_Ende;
            Prüfungsstatus = prüfungsstatus;
            Prüfungsdatum = prüfungsdatum;
            Mitarbeiter = mitarbeiter;
        }

        public Fahrzeug Fahrzeug { get; }

        public Kunde Kunde { get; }

        public DateTime Reservierung_Start { get; }

        public DateTime Reservierung_Ende { get; }

        public Prüfungsstatus Prüfungsstatus { get; set; }

        public DateTime Prüfungsdatum { get; set; }

        public Mitarbeiter Mitarbeiter { get; set; }
    }
}
