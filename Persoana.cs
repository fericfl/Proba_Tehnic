namespace Catalog
{
    public class Persoana
    {
        public string Nume { get; set; } 
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public Persoana(string nume, string prenume, int varsta)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
        }
    }
}