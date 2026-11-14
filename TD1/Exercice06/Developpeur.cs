namespace Exercice06;

public class Developpeur:Employe
{
    public string Language;
    public double prime;

    public Developpeur(int  id, string nom, double prime, string language, double salaireBase)
    {
        this.Id = id;
        this.nom = nom;
        this.prime = prime;
        this.Language = language;
        this.salaireBase = salaireBase;
    }
    
    public override double calculerSalaire()
    {
        return this.salaireBase + prime;
    }

    public override void afficherInformations()
    {
        base.afficherInformations();
        Console.WriteLine($"Language: {this.Language} | prime: {this.prime} ");
    }
}