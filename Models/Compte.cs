using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Compte : Courant
    {
        private double _solde;
        private DateTime _dateDernierRetrai;
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
    }
    }
