namespace AreaLib.Tests;

public class UnitTest1
{
    [Fact]
    public void TestCircle()
    {
        //Arrange
        var circle = new Circle(100);

        //Fact
        var area = circle.CalculateArea();

        //Assert
        Assert.Equal(31415.926535897932, area);
    }
    
    [Fact]
    public void TestTriangle()
    {
        //Arrange
        var triangle = new Triangle(3, 4, 6);

        //Fact
        var area = triangle.CalculateArea();

        //Assert
        Assert.Equal(5.332682251925386, area);
    }
    
    [Fact]
    public void TestRightTriangle()
    {
        //Arrange
        var triangle = new Triangle(3, 4, 5);

        //Fact
        var area = triangle.CalculateArea();

        //Assert
        Assert.Equal(6, area);
    }
}