using Exercice05;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Voiture v1 = new Voiture();
            Voiture v2 = new Voiture("BMW", "KA 3");
            Voiture v3 = new Voiture("mercedes", "Classe C", 2022, 120);
            Voiture v4 = new Voiture("Audi", "A4", 2000, 80);

            v1.AfficherInformations();
            v2.AfficherInformations();
            v3.AfficherInformations();
            v4.AfficherInformations();

            v3.Accelerer(30);
            v3.AfficherInformations();

            v3.Freiner(50);
            v3.AfficherInformations();

            v4.Freiner(200);
            v4.AfficherInformations();
        }
    }
}