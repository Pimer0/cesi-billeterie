namespace DemoIntrface.Classes;

public class Carre : Figure
{
    public Carre(Point origine, double cote) : base(origine)
    {
        this.cote = cote;
    }

    public double cote { get; set; }
    

}