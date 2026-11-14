namespace Exercice08;

public class PaiementCarte : IPaiement
{
    public void Payer(decimal montant)
    {
        Console.WriteLine($"Paiement par carte est effectue avec sucess \n MONTANT : {montant} DH");
    }
}