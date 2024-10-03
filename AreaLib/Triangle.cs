namespace AreaLib;

public class Triangle : IShapeWithArea
{
    private const string ErrorMessage = "Sides of triangle must be greater than 0";

    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        ValidateSides(sideA, sideB, sideC);

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public bool IsRightAngled() // Проверка на то, является ли треугольник прямоугольным
    {
        var sides = new[] { SideA, SideB, SideC }.OrderBy(x => x).ToArray();
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }

    public double CalculateArea()
    {
        var halfOfPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - SideA) * (halfOfPerimeter - SideB) * (halfOfPerimeter - SideC));
    }

    private void ValidateSides(double sideA, double sideB, double sideC)
    {
        ValidateSide(sideA);
        ValidateSide(sideB);
        ValidateSide(sideC);

        var sides = new[] { sideA, sideB, sideC }.OrderBy(x => x).ToArray();
        if(sides[0] + sides[1] <= sides[2])
            throw new ArgumentOutOfRangeException("sides", "Incorrect ratio of the sides of the triangle");
    }
    private void ValidateSide(double side)
    {
        if (side <= 0)
            throw new ArgumentOutOfRangeException(nameof(side), side, ErrorMessage);
    } 
}
