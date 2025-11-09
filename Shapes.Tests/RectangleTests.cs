namespace Shapes.Tests;

public class RectangleTests
{
    [TestCase(4, 8, 32)]
    [TestCase(0, 5, 0)]
    [TestCase(2.5, 2, 5)]
    public void Area_IsCorrect(double length, double width, double expected)
    {
        var r = new Rectangle(length, width);
        Assert.That(r.CalculateArea(), Is.EqualTo(expected).Within(1e-9));
    }

    [Test]
    public void Volume_IsZero_For2D()
    {
        var r = new Rectangle(4, 8);
        Assert.That(r.CalculateVolume(), Is.EqualTo(0).Within(1e-9));
    }
}