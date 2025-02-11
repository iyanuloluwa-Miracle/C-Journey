public interface ICalculator
{
    double Add(double x, double y);
    double Subtract(double x, double y);
    double Multiply(double x, double y);
    double Divide(double x, double y);
}

public class Calculator : ICalculator
{
    public double Add(double x, double y) => x + y;
    public double Subtract(double x, double y) => x - y;
    public double Multiply(double x, double y) => x * y;
    public double Divide(double x, double y) => x / y;
}

class Program
{
    static void Main(string[] args)
    {
        ICalculator calculator = new Calculator();
        Console.WriteLine("Add: " + calculator.Add(5, 3));
        Console.WriteLine("Subtract: " + calculator.Subtract(5, 3));
        Console.WriteLine("Multiply: " + calculator.Multiply(5, 3));
        Console.WriteLine("Divide: " + calculator.Divide(5, 3));
    }
}