using Exercice07;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cercle cer1 = new Cercle(5);
            Rectangle rec1 = new Rectangle(10, 5);
            Carre car1 = new Carre(5);
            
            Console.WriteLine(cer1.calculerSurface());
            Console.WriteLine(car1.calculerSurface());
            Console.WriteLine(rec1.calculerSurface());
            
        }
    }
}