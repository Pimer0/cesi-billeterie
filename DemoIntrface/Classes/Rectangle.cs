namespace DemoIntrface.Classes;

public class Rectangle : Figure
{
    public Rectangle(Point origine, double longueur, double largeur) : base(origine)
    {
        this.longueur = longueur;
        this.largeur = largeur;
    }

    public double longueur { get; set; }
    public double largeur { get; set; }
}