using Exercice08;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PaiementCarte pc = new PaiementCarte();
            PaiementEspece pe = new PaiementEspece();
            PaiementVirement pv = new PaiementVirement();
            Console.WriteLine("#####################################");
            pc.Payer(512);
            Console.WriteLine("#####################################");
            pe.Payer(1024);
            Console.WriteLine("#####################################");
            pv.Payer(2048);
        }
    }
}