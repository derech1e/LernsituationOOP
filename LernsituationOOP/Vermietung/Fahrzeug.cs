using LernsituationOOP.Utils;

namespace LernsituationOOP.Vermietung
{
    public class Fahrzeug
    {
        /// <summary>
        /// Konstruktor mit allen angagen die für eine Fahrzeug notwendig sind
        /// </summary>
        /// <param name="modell">Modell des Fahrzeugs</param>
        /// <param name="zustand">Aktueller Zustand des Fahrzeugs</param>
        public Fahrzeug(FahrzeugModell modell, FahrzeugStatus zustand)
        {
            Modell = modell;
            Zustand = zustand;
        }

        public FahrzeugModell Modell { get; set; }

        public FahrzeugStatus Zustand { get; set; }

    }
}
