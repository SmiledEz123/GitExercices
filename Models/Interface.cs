﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ICustomer 
    {
        double Solde {get; }
        void Depot(double Montant);
        void Retrait(double Montant);
        
    }

    public interface IBanker: ICustomer
    {
        public void AppliquerInteret();
        public Personne Titulaire { get; }
        public string Numero { get; }
    }
}

