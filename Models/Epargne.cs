using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Epargne : Compte
    {
        private double _solde = 0;
        private Personne _titulaire;
        private DateTime _dateDernierRetrai;

        public Epargne(Personne tit, string num) : base(tit, num)
        {
            _titulaire = tit;

        }
        protected override double CalculInteret()
        {
            return (_solde * 4.5)/100;
        }
        public override string ToString()
        {
            return $"Bonjour {_titulaire.Premon} {_titulaire.Nom} Voici votre solde : {_solde}";
        }

        private double Solde
        {
            get
            {
                return _solde;
            }

            set
            {
                _solde = value;
            }
        }

        Personne Titulaire
        {
            get
            {
                return _titulaire;
            }

            set
            {
                _titulaire = value;
            }
        }

        public override void Depot(double Montant)
        {
            if (Montant > 0)
            {
                Solde = Solde + Montant;
            }
            else { Console.WriteLine("Tu peux pas deposser du negatif"); }
        }

        public override void Retrait(double Montant)
        {
            if (Montant <= 0)
            {
                Console.WriteLine("Pas solde negatif ou null");
                return;
            }
            else
            {
                if (Solde - Montant < 0)
                {
                    Console.WriteLine("Solde pas suffisant");
                    return;
                }
                else
                {
                    Solde = Solde - Montant;
                    _dateDernierRetrai = DateTime.Now;
                }
            }

        }

        public static double operator +(Epargne c1, Epargne c2)
        {
            if (c1.Solde > 0 && c2.Solde > 0)
                return c1.Solde + c2.Solde;

            if (c1.Solde <= 0 && c2.Solde > 0)
                return c2.Solde;

            if (c1.Solde > 0 && c2.Solde <= 0)
                return c1.Solde;

            return 0;
        }
    }
}
