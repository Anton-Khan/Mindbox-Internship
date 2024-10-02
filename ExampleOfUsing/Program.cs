using AreaOfShape;

namespace ExampleOfUsing;

public static class Program
{
    public static void Main()
    {
        var circle = new Circle(3);
        var triangle = new Triangle(3, 4, 5);

        List<IShapeWithArea> shapes = new List<IShapeWithArea>{circle, triangle};        

        foreach(var shape in shapes)
        {
            System.Console.WriteLine($"Area of shape is {shape.CalculateArea()}");
        }
    }
}
