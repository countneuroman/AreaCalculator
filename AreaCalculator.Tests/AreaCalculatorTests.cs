using AreaCalculator.Entities;

namespace AreaCalculator.Tests;

public class AreaCalculatorTests
{
    [Fact]
    public void Success_calculate_circle_area()
    {
        var circle = new Circle(2);

        double result = circle.CalculateArea();
        
        Assert.Equal(12.566370614359172, result);
    }
    
    [Fact]
    public void Success_calculate_triangle_area()
    {
        var triangle = new Triangle(10, 11, 12);

        double result = triangle.CalculateArea();
        
        Assert.Equal(51.521233486786784, result);
    }
    
    [Fact]
    public void Is_rectangular_triangle()
    {
        var triangle = new Triangle(4, 7.5, 8.5);
        
        Assert.True(triangle.IsRightTirangle);
    }
    
    [Fact]
    public void Is_not_rectangular_triangle()
    {
        var triangle = new Triangle(5, 4, 8);
        
        Assert.False(triangle.IsRightTirangle);
    }
    
    [Fact]
    public void Circle_radius_is_negative()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-2));
    }
    
    [Fact]
    public void Triangle_sides_is_negative()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-2, 1, 3));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -2, 3));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 3, -2));
    }
}