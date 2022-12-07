namespace AreaCalculator.Entities;

public class Triangle : Figure
{
    private readonly bool _isRightTirangle;
    
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }
    
    public bool IsRightTirangle => _isRightTirangle;
    
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        FirstSide = firstSide < 0
            ? throw new ArgumentOutOfRangeException(nameof(firstSide), "Cannot be a negative value")
            : firstSide;
        SecondSide = secondSide < 0
            ? throw new ArgumentOutOfRangeException(nameof(secondSide), "Cannot be a negative value")
            : secondSide;
        ThirdSide = thirdSide < 0
            ? throw new ArgumentOutOfRangeException(nameof(thirdSide), "Cannot be a negative value")
            : thirdSide;

        _isRightTirangle = DetermineTriangleIsRectangular();
    }
    
    public override double CalculateArea()
    {
        double semiPerimeter = CalculateSemiPerimeter();
        
        return Math.Sqrt(semiPerimeter *
                         (semiPerimeter - FirstSide) *
                         (semiPerimeter - SecondSide) *
                         (semiPerimeter - ThirdSide));
    }

    private double CalculateSemiPerimeter() 
        => (FirstSide + SecondSide + ThirdSide) / 2;
    
    private bool DetermineTriangleIsRectangular()
    {
        double maxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();

        double maxSideSquare = Math.Pow(maxSide, 2);
        
        return Math.Abs(
            Math.Pow(FirstSide, 2) +
            Math.Pow(SecondSide, 2) +
            Math.Pow(ThirdSide, 2) -
            (maxSideSquare + maxSideSquare)) == 0;
    }
}