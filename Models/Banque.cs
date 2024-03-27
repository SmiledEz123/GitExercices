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
        private Dictionary<string,Compte> compte = new Dictionary<string, Compte>();


        public void Ajouter(Compte compte)
        {
            this.compte.Add(compte.Numero,compte);
        }
        public void Supprimer(string numero)
        {
            if (numero != null)
            {
                compte.Remove(numero);
            }
        }

        public Compte this[string s]
        {
            get {
                Compte p;
                this.compte.TryGetValue(s, out p);
                return p;
                }
        }
        public string NomDeLaBanqe
            {
                get
                { return _nomDeLaBanque; }
                init
                { _nomDeLaBanque = value; }
            }
        } 
    }
