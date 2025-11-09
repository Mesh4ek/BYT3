namespace Shapes;

public class Cube(double side) : IShape
{
    public double CalculateArea()  => 6 * Math.Pow(side, 2);
    public double CalculateVolume() => Math.Pow(side, 3);
}