namespace DemoIntrface.Classes;

public class Triangle : Figure
{
    

    public Triangle(Point origine, double baseTriangle, double hauteurTriangle, double coteTrois) : base(origine)
    {
        this.baseTriangle = baseTriangle;
        this.hauteurTriangle = hauteurTriangle;
        this.coteTrois = coteTrois;
    }
    public double coteTrois { get; set; }
    public double baseTriangle { get; set; }
    public double hauteurTriangle { get; set; }
    
}