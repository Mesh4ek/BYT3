namespace Calculator.Tests;

public class CalculatorTests
{
    [TestCase(2, 3, '+', 5)]
    [TestCase(2, 3, '-', -1)]
    [TestCase(2, 3, '*', 6)]
    [TestCase(10, 4, '/', 2.5)]
    [TestCase(-5, -7, '+', -12)]
    [TestCase(5, 0, '*', 0)]
    public void Compute_BasicOps(double a, double b, char op, double expected)
    {
        var c = new Calculator(a, b, op);
        Assert.That(c.Compute(), Is.EqualTo(expected).Within(1e-12));
    }

    [Test]
    public void DivideByZero_Throws()
    {
        var c = new Calculator(5, 0, '/');
        Assert.That(() => c.Compute(), Throws.TypeOf<DivideByZeroException>());
    }

    [TestCase('%')]
    [TestCase('^')]
    [TestCase('x')]
    public void UnknownOp_Throws(char op)
    {
        var c = new Calculator(1, 2, op);
        Assert.That(() => c.Compute(), Throws.ArgumentException);
    }

    [TestCase(1.2, 3.4)]
    [TestCase(-10.5, 7.25)]
    public void Addition_IsCommutative(double a, double b)
    {
        var ab = new Calculator(a, b, '+').Compute();
        var ba = new Calculator(b, a, '+').Compute();
        Assert.That(ab, Is.EqualTo(ba).Within(1e-12));
    }

    [TestCase(1.2, 3.4)]
    [TestCase(-10.5, 7.25)]
    public void Multiplication_IsCommutative(double a, double b)
    {
        var ab = new Calculator(a, b, '*').Compute();
        var ba = new Calculator(b, a, '*').Compute();
        Assert.That(ab, Is.EqualTo(ba).Within(1e-12));
    }
}
