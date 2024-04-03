namespace Xtest;
    using Models;
using System;
using Xunit.Sdk;

public class UnitTest1
    {
        [Fact]
        public void TestConstructeur()
        {
        bool test;
        Banque banque = new Banque("Bonjour");
        test = "Bonjour" == banque.NomDeLaBanqe;
        Assert.True(test);
        }

        [Fact]
        public void TestAjouterCompte()
        {
            bool test;
            Banque banque = new Banque("Bonjour");
            Courant sujet = new Courant(new Personne("joe", "doe", new DateTime(2000, 02, 10)), "500", 800d);
            banque.Ajouter(sujet);
            test = sujet == banque["500"];
            Assert.True(test);
        }
    [Fact]
    public void TestSupprimer()
    {
        bool test;
        Banque banque = new Banque("Bonjour");
        Courant sujet = new Courant(new Personne("joe", "doe", new DateTime(2000, 02, 10)), "500", 800d);
        banque.Ajouter(sujet);
        banque.Supprimer("500");
        test = sujet == banque["500"];
        Assert.False(test);
    }

    public void TestSupprimer()
    {
        bool test;
        Banque banque = new Banque("Bonjour");
        Courant sujet = new Courant(new Personne("joe", "doe", new DateTime(2000, 02, 10)), "500", 800d);
        banque.Ajouter(sujet);
        banque.Supprimer("500");
        test = sujet == banque["500"];
        Assert.False(test);
    }
}