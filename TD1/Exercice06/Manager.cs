namespace Exercice06;

public class Manager:Employe
{
    public int nombreEquipe;
    public double bonus;

    public Manager(int id, string nom, double salaire, int nombreEquipe, double bonus)
    {
        this.Id = id;
        this.nom = nom;
        this.salaireBase = salaire;
        this.nombreEquipe = nombreEquipe;
        this.bonus = bonus;
    }

    public override double calculerSalaire()
    {
        return base.calculerSalaire() + bonus;
    }
    
    public override void afficherInformations()
    {
        base.afficherInformations();
        Console.WriteLine($"nombre d'equipe: {this.nombreEquipe} | bonus : {this.bonus} ");
    }
}
