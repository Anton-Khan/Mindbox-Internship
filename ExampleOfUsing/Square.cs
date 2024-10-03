using AreaOfShape;

namespace ExampleOfUsing;

public class Square : IShapeWithArea //  Добавление новых фигур
{
    public double Side { get; }

    public Square(double side)
    {
        ValidateSide(side);

        Side = side;
    }
    
    private void ValidateSide(double side)
    {
        if(side <= 0)
            throw new ArgumentOutOfRangeException(nameof(side), "Side must be greater than 0");
    }

    public double CalculateArea() => Side * Side;
}