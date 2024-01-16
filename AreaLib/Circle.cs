namespace AreaLib;

public class Circle : IShape
{
    public Circle(double radius)
    {
        _radius = radius;
    }

    private double _radius;
    
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}