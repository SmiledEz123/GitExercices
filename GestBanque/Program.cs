namespace GestBanque;
    using Models;
    internal class Program
    {
<<<<<<< Updated upstream
        static void Main(string[] args)
        {
        Courant courant = new Courant();
        Banque banque = new Banque();
        courant.Titulaire = new Personne();
        courant.Titulaire.Premon = "Jean";
        courant.Titulaire.Nom = "Claude";
        courant.Numero = "1";
        courant.Depot(100);
        banque.Ajouter(courant);
        Console.WriteLine(banque["1"].Titulaire.Premon);
=======
    static void Main(string[] args)
    {
        Banque banque = new Banque();
        Epargne epargne = new Epargne();
        epargne.Depot(10.50d);
        epargne.Titulaire = new Personne() { Nom = "Adelle", Premon = "Ada" };
        Console.WriteLine(epargne);
       


>>>>>>> Stashed changes
    }

}