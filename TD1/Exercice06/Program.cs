using Exercice06;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation des developpeurs
            Developpeur d1 = new Developpeur(1, "Ahmed", 8000, "C#", 1500);
            Developpeur d2 = new Developpeur(2, "Youssef", 9000, "Java", 2000);
            Developpeur d3 = new Developpeur(3, "Amine", 7500, "Python", 1000);

            // Creation des managers
            Manager m1 = new Manager(4, "Karim", 12000, 5, 3000);
            Manager m2 = new Manager(5, "Omar", 15000, 8, 4000);

            // Affichage des informations
            Console.WriteLine("\n############################# Developpers ################### \n");

            d1.afficherInformations();
            d2.afficherInformations();
            d3.afficherInformations();

            Console.WriteLine("\n############################# MANAGERS ################### \n");

            m1.afficherInformations();
            m2.afficherInformations();
        }
    }
}