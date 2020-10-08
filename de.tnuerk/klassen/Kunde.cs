using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernsituationOOP.de.tnuerk.klassen
{
    class Kunde : Person
    {

        public Kunde(string vorname, string nachname,  DateTime geburtsdatum, string adresse, string email, int telefonnummer, int nummer, bool führerschein) : base(vorname, nachname, geburtsdatum, adresse, email, telefonnummer)
        {
            Nummer = nummer;
            Führerschein = führerschein;
        }

        public int Nummer { get; set; }

        public bool Führerschein { get; set; }
    }
}
