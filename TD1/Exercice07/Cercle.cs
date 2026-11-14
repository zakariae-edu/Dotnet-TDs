namespace Exercice07;

public class Cercle : Forme
{
    public double r;

    public Cercle(double r)
    {
        this.r = r;
    }

    public override double calculerSurface()
    {
        return 3.14*this.r*this.r;
    }
}