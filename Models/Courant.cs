namespace Models;

public class Courant : Compte
{
    private double _ligneDeCredit, _solde = 0;
    private Personne _titulaire;

    public Courant(Personne tit,string num) : base (tit,num)
    {
        _titulaire = tit;

    }

    public Courant(Personne tit, string num,double lC) : base(tit, num)
    {
        _titulaire = tit;
        _ligneDeCredit = lC;

    }

    protected override double CalculInteret()
    {
        if (_solde >= 0)
        {
            return (_solde *3)/100;
        }
        else { return (_solde*9.75)/100; }
    }
    public override string ToString()
    {
        return $"Bonjour {_titulaire.Premon} {_titulaire.Nom} Voici votre solde : {_solde}";
    }

    private double LigneDeCredit
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

    private Personne Titulaire
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
