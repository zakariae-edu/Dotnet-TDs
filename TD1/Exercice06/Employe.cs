namespace Exercice06;

public class Employe
{
    public int Id ;
    public string nom;
    public double salaireBase;

    public virtual double calculerSalaire()
    {
        return salaireBase;
    }

    public virtual void afficherInformations()
    {
        Console.WriteLine($"ID : {this.Id}, Nom: {this.nom} | Salaire Base: {this.salaireBase}");
    }
}