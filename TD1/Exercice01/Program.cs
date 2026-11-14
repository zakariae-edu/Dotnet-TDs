using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Zakariae", "Chriaa", 25);
            Personne p2 = new Personne("Smair", "Ahmadi", 17);
            Personne p3 = new Personne("Salma", "Slawi", 52);

            p1.afficherInformations();
            p2.afficherInformations();
            p3.afficherInformations();

            string adult1, adult2, adult3;
            
            adult1 = p1.estMajeure() ? "Adult":"Minor";
            adult2 = p2.estMajeure() ? "Adult":"Minor";
            adult3 = p3.estMajeure() ? "Adult":"Minor";
            
            Console.WriteLine(adult1);
            Console.WriteLine(adult2);
            Console.WriteLine(adult3);
        }
    }
}