namespace LernsituationOOP.Vermietung
{
    public class Autovermieter
    {
        public Autovermieter(string name, string standort, int rufnummer)
        {
            Name = name;
            Standort = standort;
            Rufnummer = rufnummer;
        }

        public string Name { get; }

        public string Standort { get; }

        public int Rufnummer { get; }
    }
}