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
        private Dictionary<string,Courant> compte = new Dictionary<string, Courant>();


        public void Ajouter(Courant compte)
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

        public Courant this[string s]
        {
            get {
                Courant p;
                this.compte.TryGetValue(s, out p);
                return p;
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
