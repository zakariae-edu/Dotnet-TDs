namespace Exercice07;

public class Rectangle : Forme
{
    public double longeur;
    public double largeur;

    public Rectangle(double longeur, double largeur)
    {
        this.longeur = longeur;
        this.largeur = largeur;
    }

    public override double calculerSurface()
    {
        return this.longeur * this.largeur;
    }
    
}