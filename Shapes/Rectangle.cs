namespace Shapes;

public class Rectangle(double length, double width) : IShape
{
    public double CalculateArea()  => length * width;
    public double CalculateVolume() => 0; // 2D shape
}