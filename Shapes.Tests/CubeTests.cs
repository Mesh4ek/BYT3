namespace Shapes.Tests;

public class CubeTests
{
    [TestCase(4)]
    [TestCase(0)]
    [TestCase(2.5)]
    public void Area_IsCorrect(double side)
    {
        var c = new Cube(side);
        var expected = 6 * Math.Pow(side, 2);
        Assert.That(c.CalculateArea(), Is.EqualTo(expected).Within(1e-9));
    }

    [TestCase(4)]
    [TestCase(0)]
    [TestCase(2.5)]
    public void Volume_IsCorrect(double side)
    {
        var c = new Cube(side);
        var expected = Math.Pow(side, 3);
        Assert.That(c.CalculateVolume(), Is.EqualTo(expected).Within(1e-9));
    }
}