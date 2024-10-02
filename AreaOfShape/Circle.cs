namespace AreaOfShape;

public class Circle : IShapeWithArea
{
    public double Radius { get; }

    public Circle(double radius)
    {
        ValidateRadius(radius);

        Radius = radius;
    }

    private void ValidateRadius(double radius)
    {
        if(radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be greater than 0");
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
