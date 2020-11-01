using LernsituationOOP.de.tnuerk.klassen.utils;

namespace LernsituationOOP.Vermietung
{
    public class Fahrzeug
    {
        public Fahrzeug(FahrzeugModell modell, FahrzeugStatus zustand)
        {
            Modell = modell;
            Zustand = zustand;
        }

        public FahrzeugModell Modell { get; set; }

        public FahrzeugStatus Zustand { get; set; }

    }
}
