namespace Exercice07;

public class Carre:Forme
{
    public double a;

    public Carre(double a)
    {
        this.a = a;
    }
    public override double calculerSurface()
    {
        return this.a*this.a;
    }
}