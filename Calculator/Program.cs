namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        var calc = new Calculator(10, 4, '/');
        Console.WriteLine(calc.Compute());
    }
}