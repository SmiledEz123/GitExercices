﻿namespace Models;

public class Courant
{
    private string _numero;
    private double _ligneDeCredit, _solde;
    private Personne _titulaire;

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

    public double LigneDeCredit
    {
        
        get
        {
           
                return _ligneDeCredit;
        }

    set
        {
            if (value > 0)
            {
                _ligneDeCredit = value;
            }
        }
    }

    public double Solde
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

    public void Depot(double Montant)
    {
        if (Montant > 0)
        {
            Solde = Solde + Montant;
        }
        else { Console.WriteLine("Tu peux pas deposser du negatif"); }
    }

    public void Retrait(double Montant)
    {
        if (Montant <= 0)
        { Console.WriteLine("Pas solde negatif");
            return;
        }
        else
        {
            if (Solde - Montant <= -LigneDeCredit)
            {
                Console.WriteLine("Solde pas suffisant");
                return;
            }
            else
            {
                Solde = Solde - Montant;
            }
        }

    }
}