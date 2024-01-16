namespace AreaLib;

public class Triangle : IShape
{
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
        _sortedSides = new[] { firstSide, secondSide, thirdSide };
        Array.Sort(_sortedSides);
    }

    private double _firstSide;
    private double _secondSide;
    private double _thirdSide;
    private readonly double[] _sortedSides;

    private bool IsRightTriangle()
    {
        return Math.Pow(_sortedSides[2], 2) == Math.Pow(_sortedSides[0], 2) + Math.Pow(_sortedSides[1], 2);
    }
    
    public double CalculateArea()
    {
        if (IsRightTriangle())
        {
            return 0.5 * _sortedSides[0] * _sortedSides[1];
        };
        
        var p = (_firstSide + _secondSide + _thirdSide) / 2;
        return Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
    }
}