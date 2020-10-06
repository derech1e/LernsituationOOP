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
        public FahrzeugModell Modell { get; set; }

        public utils.FahrzeugStatus Zustand { get; set; }

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
