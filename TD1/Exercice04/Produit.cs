namespace Exercice04;

public class Produit
{
    public string code;
    public string nom;
    public double prix;
    public int quantiteStock;

    public Produit(string code, string nom, double prix, int quantiteStock)
    {
        this.code = code;
        this.nom = nom;
        this.prix = prix;
        this.quantiteStock = quantiteStock;
    }

    public double calculerValeurStock()
    {
        return this.prix * this.quantiteStock;
    }
    
    public void ajouterStock(int quantite)
    {
        this.quantiteStock+=quantite;
    }

    public void Vendre(int quantite)
    {
        if (quantite <= quantiteStock){
            this.quantiteStock -= quantite;
            Console.WriteLine($"Le prix est : {this.prix * quantite}$ \n L'etat : Vendu");
        }
        else
        {
            throw new ArgumentException($"{quantite} est plus grand que la quantite valable {this.quantiteStock} , L'etat : non-Vendu");
        }
    }

    public void AfficherProduit()
    {
        Console.WriteLine($"Code : {this.code} |  Nom : {this.nom} | Prix : {this.prix} | Quantite Stock : {this.quantiteStock}");
    }
}