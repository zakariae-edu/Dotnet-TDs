namespace Exercice08;

public class PaiementVirement:IPaiement
{
    public void Payer(decimal montant)
    {
        Console.WriteLine($"Votre Virement a ete effectuer avec sucess \n MONTANT {montant}DH");
    }
}