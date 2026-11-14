using Exercice04;

namespace ConsoleApp1
{
    class Program
        {
            static void Main(string[] args)
            {
                Produit p1 = new Produit("6546ER", "Souris", 120, 150);
                Produit p2 = new Produit("44488F", "Keyboard", 180, 150);
                Produit p3 = new Produit("5889DS", "Screen", 2900, 150);
                Produit p4 = new Produit("2155RT", "Laptop", 6000, 150);
                
                Console.WriteLine(p1.calculerValeurStock());
                Console.WriteLine(p2.calculerValeurStock());
                Console.WriteLine(p3.calculerValeurStock());
                
                p1.AfficherProduit();
                p1.ajouterStock(50);
                p1.AfficherProduit();
                
                p2.AfficherProduit();
                p2.Vendre(200);
                p2.AfficherProduit();
                
                p2.Vendre(200);
                p2.AfficherProduit();
                
                
            }
        }
};

