namespace DemoIntrface.Classes;

public class Point
{
    public double posX { get; set; }
    public double posY { get; set; }
    public Point(int x, int y)
    {
        posX = x;
        posY = y;
    }
    
    public override string ToString()
    {
        return $"({posX}, {posY})";
    }
}