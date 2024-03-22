using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banque
    {
        private string _nomDeLaBanque;
        private Dictionary<string,Personne> compte = new Dictionary<string, Personne>();


        public void Ajouter(Courant compte)
        {
            this.compte.Add(compte.Numero,compte.Titulaire);
        }
        public void Supprimer(string numero)
        {
            if (numero != null)
            {
                compte.Remove(numero);
            }
        }

        public Personne this[string s]
        {
            get {
                Personne p;
                this.compte.TryGetValue(s, out p);
                return p;
                }
            set 
            {
                this.compte[s] = value;
            }
        }
        public string NomDeLaBanqe
            {
                get
                { return _nomDeLaBanque; }
                set
                { _nomDeLaBanque = value; }
            }
        } 
    }
