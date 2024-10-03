namespace AreaOfShape;

public class Circle : IShapeWithArea
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be greater than 0");

        Radius = radius;
    }

    public double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
}
