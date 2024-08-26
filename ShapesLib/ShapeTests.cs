using ShapesLib;
using ShapesLib.Example;
using Xunit;

public class ShapeTests
{
    [Fact]
    public void CircleArea_CorrectInput_ReturnsCorrectArea()
    {
        var circle = new Circle(5);
        var expectedArea = Math.PI * 25;
        Assert.Equal(expectedArea, circle.GetArea(), precision: 5);
    }

    [Fact]
    public void TriangleArea_CorrectInput_ReturnsCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        var expectedArea = 6;
        Assert.Equal(expectedArea, triangle.GetArea(), precision: 5);
    }

    [Fact]
    public void Triangle_IsRightAngled_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled());
    }

    [Fact]
    public void Triangle_InvalidSides_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
    }

    [Fact]
    public void CalculateArea_ForCircle_ReturnsCorrectArea()
    {
        var shape = new Circle(5);
        var expectedArea = Math.PI * 25;
        Assert.Equal(expectedArea, shape.GetArea(), precision: 5);
    }
    
    [Fact]
    public void CalculateAreaSum()
    {
        var circle = new Circle(5);
        var expectedCircleArea = Math.PI * 25;
        Assert.Equal(expectedCircleArea*2, Utils.CalculateAreaSum(new []{circle, circle}), precision: 5);
    }
}