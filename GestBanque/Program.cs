namespace GestBanque;
    using Models;
internal class Program
{
        static void Main(string[] args)
        {
        Courant courant = new Courant(new Personne() {Nom = "Jean", Premon ="Claude"},"1");
        Banque banque = new Banque();
        courant.Depot(100);
        banque.Ajouter(courant);
        Console.WriteLine(banque["1"].Titulaire.Premon);
        Epargne epargne = new Epargne(new Personne() { Nom = "Adelle", Premon = "Ada" },"2");
        epargne.Depot(10.50d);

    }

}