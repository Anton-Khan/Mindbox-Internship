namespace AreaLib.Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public async Task CalculateArea_RaduisEquals5_AreaEquals25PI()
    {
        var circle = new Circle(5);
        var expected = 25 * Math.PI;

        var actual = circle.CalculateArea();

        Assert.AreEqual(expected, actual);
    }
}
