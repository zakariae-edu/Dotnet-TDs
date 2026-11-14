namespace Exercice05;

public class Voiture
{
    public string marque;
    public string modele;
    public int annee;
    public double vitesse;

    public Voiture()
    {
        this.marque = "unkown";
        this.modele = "Unknown";
        this.annee = 0;
        this.vitesse = 0;
    }

    public Voiture(string marque, string modele)
    {
        this.marque = marque;
        this.modele = modele;
        this.annee = 0;
        this.vitesse = 0;
    }

    public Voiture(string marque, string modele, int annee, double vitesse)
    {
        this.marque = marque;
        this.modele = modele;
        this.annee = annee;
        this.vitesse = vitesse;
    }

    public void Accelerer(double valeur)
    {
        if (valeur > 0)
        {
            this.vitesse += valeur;
        }
    }

    public void Freiner(double valeur)
    {
        if (valeur > 0)
        {
            this.vitesse -= valeur;

            if (this.vitesse < 0)
            {
                this.vitesse = 0;
            }
        }
    }

    public void AfficherInformations()
    {
        Console.WriteLine($"Marque : {this.marque} | Modele : {this.modele} | Annee : {this.annee} | Vitesse : {this.vitesse} km par h");
    }
}