namespace Models
{
    public class Personne
    {
        public string Nom { get; init; }
        public string Premon{ get; init; }
        public DateTime DateNaiss { get; init; }

        public Personne(string nom, string premon, DateTime dateNaiss)
        {
            Nom = nom;
            Premon = premon;
            DateNaiss = dateNaiss;
        }
        public Personne()
        {
        }
    }
}
