namespace GestBanque;
    using Models;
    internal class Program
    {
        static void Main(string[] args)
        {
        Personne doeJhon = new Personne()
        {
            Nom = "Doe",
            Premon = "Jhon",
            DateNaiss = new DateTime(19, 1, 1)
        };

        Courant courant = new Courant() 
        { Numero = "0001",
          LigneDeCredit = 500, 
          Titulaire = doeJhon };

        courant.Depot(10);
        courant.Depot(-20);
        }

    }