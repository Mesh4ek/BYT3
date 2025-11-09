namespace Shapes.Tests;

public class SphereTests
{
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(5.5)]
    public void Area_IsCorrect(double r)
    {
        var s = new Sphere(r);
        var expected = 4 * Math.PI * Math.Pow(r, 2);
        Assert.That(s.CalculateArea(), Is.EqualTo(expected).Within(1e-9));
    }

    [TestCase(0)]
    [TestCase(2)]
    [TestCase(10)]
    public void Volume_IsCorrect(double r)
    {
        var s = new Sphere(r);
        var expected = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
        Assert.That(s.CalculateVolume(), Is.EqualTo(expected).Within(1e-9));
    }
}