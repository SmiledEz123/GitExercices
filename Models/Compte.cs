using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Compte
    {
        private double _solde;
        private DateTime _dateDernierRetrai;
        private Personne _titulaire;
        private double _interet;
        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            _solde += _solde + CalculInteret();
        }

        public virtual double Solde
        {
            get
            {
                return _solde;
            }

            private set
            {
                _solde = value;
            }
        }

        public double Interet
        {
            get { return _interet; }
        }

        public Personne Titulaire
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

        public virtual void Depot(double Montant)
        {
            if (Montant > 0)
            {
                Solde = Solde + Montant;
            }
            else { Console.WriteLine("Tu peux pas deposser du negatif"); }
        }

        public virtual void Retrait(double Montant)
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
    }
}
