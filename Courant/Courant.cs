using Personne;
namespace Courant
{
    public class Courant
    {
        string Numero;
        double LigneDeCredit, Solde;
        Personne.Personne Titulaire;

        public void Depot(double Montant)
        {
            if (Montant > 0)
            {
                Solde = Solde + Montant;
            }
        }

        public void Retrait(double Montant)
        {
            if (Solde - Montant < -LigneDeCredit)
            {
                return;
            }
            else
            {
                Solde = Solde - Montant;
            }

        }
    }
}
