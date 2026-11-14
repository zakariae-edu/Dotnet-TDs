namespace ConsoleApp1;

public class Personne
{
    public string Nom;
    public string Prenom;
    public int Age;
    
    // Le Constructeur
    
    public Personne(string nom, string prenom, int age)
    {
        this.Nom = nom;
        this.Prenom = prenom;
        this.Age = age;
    }

    public void afficherInformations()
    {
        Console.WriteLine($"Nom: {this.Nom} | Prenom: {this.Prenom} | Age: {this.Age}");
    }
    public Boolean estMajeure(){
        return this.Age >= 18;
    }
}