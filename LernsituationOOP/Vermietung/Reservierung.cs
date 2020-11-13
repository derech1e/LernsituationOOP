using LernsituationOOP.Personen;
using LernsituationOOP.Utils;
using Newtonsoft.Json;
using System;

namespace LernsituationOOP.Vermietung
{
    public class Reservierung
    {
        /// <summary>
        /// Konstruktor mit allen angaben, die für eine Reservierung notwendig sind. "[JsonConstructor]" legt den Konstruktor fest, der für das Speichern verwendet werden soll.
        /// </summary>
        /// <param name="fahrzeug">Fahrzeug dass Reserviert werden soll</param>
        /// <param name="kunde">Kunde der die Reservierung vornimmt</param>
        /// <param name="reservierung_Start">Reservierungs von</param>
        /// <param name="reservierung_Ende">Reservierung bis</param>
        /// <param name="prüfungsstatus">Status der Reservierung</param>
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

        /// <summary>
        /// Konstruktor mit allen angaben, die für eine Reservierung notwendig sind.
        /// </summary>
        /// <param name="fahrzeug">Fahrzeug dass Reserviert werden soll</param>
        /// <param name="kunde">Kunde der die Reservierung vornimmt</param>
        /// <param name="reservierung_Start">Reservierungs von</param>
        /// <param name="reservierung_Ende">Reservierung bis</param>
        /// <param name="prüfungsstatus">Status der Reservierung</param>
        /// <param name="prüfungsdatum">Datum der Prüfung der Reservierung</param>
        /// <param name="mitarbeiter">Mitarbeiter der die Reservierung geprüft hat</param>
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
