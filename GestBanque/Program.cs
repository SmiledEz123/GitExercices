namespace GestBanque;
    using Models;
    internal class Program
    {
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
    }

}