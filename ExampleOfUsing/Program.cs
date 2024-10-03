using AreaLib;

namespace ExampleOfUsing;

public static class Program
{
    public static void Main()
    {
        var circle = new Circle(3);
        var triangle = new Triangle(3, 4, 5);

        var square = new Square(5); // добавленная фигура, которой нет в библиотеке

        var shapes = new List<IShapeWithArea> { circle, triangle, square }; // Вычисление площади фигуры без знания типа фигуры в compile-time
        foreach (var shape in shapes)
        {
            System.Console.WriteLine($"Area of shape is {shape.CalculateArea()}");
        }
    }
}
