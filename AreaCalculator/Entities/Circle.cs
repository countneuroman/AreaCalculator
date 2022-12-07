namespace AreaCalculator.Entities;

public class Circle : Figure
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        Radius = radius < 0
            ? throw new ArgumentOutOfRangeException(nameof(radius), "Cannot be a negative value")
            : radius;
    }

    public override double CalculateArea() 
        => Math.PI * Math.Pow(Radius, 2);
}