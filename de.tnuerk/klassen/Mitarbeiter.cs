using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernsituationOOP.de.tnuerk.klassen
{
    class Mitarbeiter : Person
    {
        public Mitarbeiter(string name, DateTime geburtsdatum, string adresse, string email, int telefonnummer, int nummer) : base(name, geburtsdatum, adresse, email, telefonnummer)
        {
            Nummer = nummer;
        }

        public int Nummer { get; set; }
    }
}
