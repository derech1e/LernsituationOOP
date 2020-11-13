namespace LernsituationOOP.Vermietung
{
    public class Autovermieter
    {
        /// <summary>
        /// Konstruktor mit allen angagen die für einen Autovermieter notwendig sind
        /// </summary>
        /// <param name="name">Name der Autovermietung</param>
        /// <param name="standort">Name des Standortes der Autovermietung</param>
        /// <param name="rufnummer">Telefonnummer der Autovermietung</param>
        public Autovermieter(string name, string standort, int telefonnummer)
        {
            Name = name;
            Standort = standort;
            Telefonnummer = telefonnummer;
        }

        public string Name { get; }

        public string Standort { get; }

        public int Telefonnummer { get; }
    }
}