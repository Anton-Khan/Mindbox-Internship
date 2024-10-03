namespace AreaOfShape.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public async Task CalculateArea_SidesEquals345_AreaEquals6()
    {
        var triangle = new Triangle(3, 4, 5);
        var expected = 6;

        var actual = triangle.CalculateArea();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public async Task IsRightAngled_SidesEquals345_True()
    {
        var triangle = new Triangle(3, 4, 5);
        var expected = true;

        var actual = triangle.IsRightAngled();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public async Task IsRightAngled_SidesEquals346_False()
    {
        var triangle = new Triangle(3, 4, 6);
        var expected = false;

        var actual = triangle.IsRightAngled();

        Assert.AreEqual(expected, actual);
    }
}
