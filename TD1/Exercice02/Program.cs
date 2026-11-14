using Exercice02;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire cp1 = new CompteBancaire("855599966", "Zakariae", 2500);
            CompteBancaire cp2 = new CompteBancaire("574343457", "Saoud", 5599);
            CompteBancaire cp3 = new CompteBancaire("453487896", "Samir", 6776);

            cp1.Deposer(500);
            cp1.afficherSolde();
            
            cp2.Retirer(30000);
            cp2.afficherSolde();
            
            cp3.Retirer(9);
            cp3.afficherSolde();
        }
    }
}