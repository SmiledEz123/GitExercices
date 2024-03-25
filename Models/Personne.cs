namespace Models
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Premon{ get; set; }
        public DateTime DateNaiss { get; set; }


        public static bool operator ==(Personne p1, Personne p2)
        {
            if(p1.Premon == null || p2.Premon == null) return false;
            if (p1.Nom == null || p2.Nom == null) return false;
            if(p1.Premon == p2.Premon && p1.Nom == p2.Nom && p1.DateNaiss == p2.DateNaiss) return true;
            return false;
        }
        public static bool operator !=(Personne p1, Personne p2)
        {
            if (p1.Premon == null || p2.Premon == null) return true;
            if (p1.Nom == null || p2.Nom == null) return true;
            if (p1.Premon == p2.Premon && p1.Nom == p2.Nom && p1.DateNaiss == p2.DateNaiss) return false;
            return true;
        }
    }

    
}
