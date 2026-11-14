namespace Exercice02;

public class CompteBancaire
{
    public string numCompte;
    public string titulaire;
    public decimal solde;

    public CompteBancaire(string numCompte, string titulaire, decimal solde)
    {
        this.numCompte = numCompte;
        this.titulaire = titulaire;
        this.solde = solde;
    }

    public bool Deposer(decimal montant)
    {
        if (montant > 0)
        {
            this.solde += montant;
            Console.WriteLine($"{montant} MAD est ajoutée au compte avec succes!");
            return true;
        }
        else
        {
            Console.WriteLine("le montant doit etre un nombre valide!!");
            return false;
        }
    }

    public bool Retirer(decimal montant)
    {
        if (montant > this.solde)
        {
            Console.WriteLine("Cet operation ne peut pas etre effectuer!!");
            return false;
        }
        else
        {
            this.solde -= montant;
            Console.WriteLine($"{montant} MAD retirer avec succes!");
            return true;
        }
    }

    public void afficherSolde()
    {
        Console.WriteLine($"Numero de Compte : {this.numCompte} |Titulaire: {this.titulaire} | Solde: {this.solde}");
    }
    
}