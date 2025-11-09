namespace Calculator;

public class Calculator(double a, double b, char op)
{
    public double A { get; } = a;
    public double B { get; } = b;
    public char Operation { get; } = op;

    public double Compute() =>
        Operation switch
        {
            '+' => A + B,
            '-' => A - B,
            '*' => A * B,
            '/' => B == 0 ? throw new DivideByZeroException("Division by zero.") : A / B,
            _  => throw new ArgumentException($"Unsupported op '{Operation}'. Use + - * /")
        };
}