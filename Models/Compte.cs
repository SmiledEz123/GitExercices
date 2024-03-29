using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
namespace Models
{
    public abstract class Compte : IBanker, ICustomer
    {
        private string _numero;
        private double _solde;
        private DateTime _dateDernierRetrai;
        private Personne _titulaire;
        private double _interet;
        private const int minimomDepot= 0;
        protected abstract double CalculInteret();

        public Compte(Personne tit, string num)
        {
            _numero = num;
            _titulaire = tit;
        }
        public Compte(Personne tit, string num,double solde)
        {
            _numero = num;
            _titulaire = tit;
            _solde = solde;
        }

        public void AppliquerInteret()
        {
            _solde += _solde + CalculInteret();
        }
        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
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
            if (Montant <= minimomDepot)
                throw new ArgumentOutOfRangeException(nameof(Montant),$"le Montant doit etre plus grand que {minimomDepot}");

            _solde += Montant;
        }

        public virtual void Retrait(double Montant)
        {
            if (Montant <= 0)
                throw new ArgumentOutOfRangeException(nameof(Montant), $"le Montant doit etre plus grand que {minimomDepot}");
            else
            {
                if (Solde - Montant < 0)
                    throw new SoldeInsuffisantException("Pas assez d argent");
                else
                {
                    Solde = Solde - Montant;
                    _dateDernierRetrai = DateTime.Now;
                }
            }
        }
    }
}
