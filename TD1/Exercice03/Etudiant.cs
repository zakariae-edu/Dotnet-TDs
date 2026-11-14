namespace Exercice03;

public class Etudiant
{
    private string _matricule;
    private string _nom;
    private double _note1,  _note2, _note3;
    private double _moyenne;

    public Etudiant(string matricule, string nom, double note1, double note2, double note3)
    {
        this._matricule = matricule;
        this._nom = nom;
        this._moyenne = 0;
        if (0<=note1 && note1 <= 20 && note2 >= 0 && note2 <= 20 && note3 <= 20 && note3 >= 0)
        {
            this._note1 = note1;
            this._note2 = note2;
            this._note3 = note3;
        }
        else
        {
            throw new ArgumentException("Tous les notes doivent etre entre 0 et 20 !!");
        }
    }

    public void Calcule_Moyenne()
    {
        _moyenne = (this._note1 + this._note2 + this._note3) / 3;
    }

    public void AfficherResultat()
    {
        Console.WriteLine($"Note1 : {_note1} |  Note2 : {_note2} | Note3 : {_note3}");
        Console.WriteLine($"Moyenne : {_moyenne:F2}");
        if (_moyenne > 10)
        {
            Console.WriteLine($"Valide");
        }
        else
        {
            Console.WriteLine($"Ajourne");
        }
    }
    
}
