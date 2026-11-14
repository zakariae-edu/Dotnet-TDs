using Exercice03;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant et1 = new Etudiant("LO56998", "Zakariae", 18,12,15); 
            Etudiant et2 = new Etudiant("P558877", "Samir", 10,10,8); 
            Etudiant et3 = new Etudiant("V36998", "Salma", 9,11,12); 
            Etudiant et4 = new Etudiant("E45454", "hamid", 20,10,13.2); 
            Etudiant et5 = new Etudiant("QA8789", "Camela", 14.4,16.2,10.5);

            et1.Calcule_Moyenne();
            et2.Calcule_Moyenne();
            et3.Calcule_Moyenne();
            et4.Calcule_Moyenne();
            et5.Calcule_Moyenne();

            et1.AfficherResultat();
            et2.AfficherResultat();
            et3.AfficherResultat();
            et4.AfficherResultat();
            et5.AfficherResultat();
            
        }
    }
}