namespace GestBanque;
    using Models;
    internal class Program
    {
    static void Main(string[] args)
    {
        Courant courant = new Courant();
        Courant courant2 = new Courant();
        Courant courant3 = new Courant()
        {
            Titulaire = new Personne() { Premon = "Jessica", Nom = "Albanaise", DateNaiss = new DateTime(1998, 10, 2) },
            Numero = "3"
    };
        
        Banque banque = new Banque();
        courant.Titulaire = new Personne();
        courant.Titulaire.Premon = "Jean";
        courant.Titulaire.Nom = "Claude";
        courant.Numero = "1";
        courant.Depot(100);
        banque.Ajouter(courant);
        courant3.Titulaire = courant.Titulaire;
        courant3.Titulaire.Premon = "Jean";
        courant3.Titulaire.Nom = "Claude";
        courant3.Numero = "2";
        courant3.Depot(200);
        banque.Ajouter(courant3);
        courant2.Titulaire = new Personne();
        courant2.Titulaire.Premon = "Janne";
        courant2.Titulaire.Nom = "Cladia";
        courant2.Numero = "3";
        courant2.Depot(300);
        banque.Ajouter(courant2);
        banque.AvoirDesComptes(courant.Titulaire);


    }

}