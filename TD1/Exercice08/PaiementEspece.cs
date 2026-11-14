namespace Exercice08;

public class PaiementEspece : IPaiement
{
    public void Payer(decimal montant)
    {
        Console.WriteLine($"Paiement par espece est effectue avec sucess \n MONTANT : {montant}DH");
    }
}