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

        public void AvoirDesComptes(Personne personne)
        {
            Courant courant = new Courant();
            foreach (KeyValuePair<string,Courant> c in compte)
            {
                Console.WriteLine(compte.Count);
                Personne test = c.Value.Titulaire;
                Console.WriteLine(test.Premon);
                Console.WriteLine(personne.Premon);
                if (test == personne)
                {
                    Console.WriteLine("Avant Ajout: " + courant.Solde);
                    Console.WriteLine("Ce que ont ajoute: " + c.Value.Solde);
                    courant.Depot(c.Value.Solde);
                    Console.WriteLine("Apres Ajout: " + courant.Solde);
                }
                
            }
            Console.WriteLine("Voici les compte: " + courant.Solde);
        }
    } 
    }
