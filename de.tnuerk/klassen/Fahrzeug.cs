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
        public Fahrzeug(FahrzeugModell modell, FahrzeugStatus zustand, int parknummer, int grundpreis)
        {
            Modell = modell;
            Zustand = zustand;
            Parknummer = parknummer;
            _Grundpreis = grundpreis;
        }

        public FahrzeugModell Modell { get; set; }

        public FahrzeugStatus Zustand { get; set; }

        public int Parknummer { get; set; }

        private int _Grundpreis;

        public int Grundpreis
        {
            get => _Grundpreis;
            set
            {
                if (_Grundpreis < 0) _Grundpreis = 0;
                _Grundpreis = value;
            }
        }
    }
}
