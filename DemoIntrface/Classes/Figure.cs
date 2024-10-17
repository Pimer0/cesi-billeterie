namespace DemoIntrface.Classes;

public abstract class Figure : IDeplacable
{
    public Point origine { get; set; }
    public Figure(Point origine)
    {
        this.origine = origine;
    }

    public string deplacement(double x, double y)
    {
        return "La figure a été déplacée";
    }
}