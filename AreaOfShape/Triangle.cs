namespace AreaOfShape;

public class Triangle : IShapeWithArea
{
    private const string ErrorMessage = "Sides of triangle must be greater than 0";

    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        ValidateSidesLength(sideA, sideB, sideC);

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private void ValidateSidesLength(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0)
            throw new ArgumentOutOfRangeException(nameof(sideA), ErrorMessage);
        if (sideB <= 0)
            throw new ArgumentOutOfRangeException(nameof(sideB), ErrorMessage);
        if (sideC <= 0)
            throw new ArgumentOutOfRangeException(nameof(sideC), ErrorMessage);

        var sides = new[] { SideA, SideB, SideC }.OrderBy(x => x).ToArray();
        if(sides[0] + sides[1] > sides[2])
            throw new ArgumentOutOfRangeException("Incorrect ratio of the sides of the triangle");
    }

    public bool IsRightAngled()
    {
        var sides = new[] { SideA, SideB, SideC }.OrderBy(x => x).ToArray();
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }

    private double CalculateHalfOfPerimeter()
    {
        return (SideA + SideB + SideC) / 2;
    }
    public double CalculateArea()
    {
        var halfOfPerimeter = CalculateHalfOfPerimeter();
        return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - SideA) * (halfOfPerimeter - SideB) * (halfOfPerimeter - SideC));
    }
}
