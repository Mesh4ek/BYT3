namespace Shapes.Tests;

public class CylinderTests
{
    [TestCase(3, 7)]
    [TestCase(0, 5)]
    [TestCase(4.25, 0)]
    public void Area_IsCorrect(double r, double h)
    {
        var c = new Cylinder(r, h);
        var expected = 2 * Math.PI * r * (r + h);
        Assert.That(c.CalculateArea(), Is.EqualTo(expected).Within(1e-9));
    }

    [TestCase(3, 7)]
    [TestCase(0, 5)]
    [TestCase(4.25, 0)]
    public void Volume_IsCorrect(double r, double h)
    {
        var c = new Cylinder(r, h);
        var expected = Math.PI * r * r * h;
        Assert.That(c.CalculateVolume(), Is.EqualTo(expected).Within(1e-9));
    }
}