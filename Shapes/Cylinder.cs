namespace Shapes;

public class Cylinder(double radius, double height) : IShape
{
    public double CalculateArea()  => 2 * Math.PI * radius * (radius + height);
    public double CalculateVolume() => Math.PI * radius * radius * height;
}