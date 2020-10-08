using LernsituationOOP.de.tnuerk.klassen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernsituationOOP.de.tnuerk.klassen
{
    class Fahrzeug
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
