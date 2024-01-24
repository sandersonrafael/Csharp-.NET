using DelegatesCs.Services;

/* Delegate */

internal class Program
{
    // A delegate is like a contract by an interface
    // He isn't implemented, but just declare the arguments and return types
    delegate double BinaryNumericOperation(double n1, double n2);

    private static void Main(string[] args)
    {
        double a = 10.0;
        double b = 12.0;


        double result = CalculationService.Sum(a, b);
        Console.WriteLine($"CalculationService.Sum(a, b): {result}");

        // The delegate method can receive a function by attribution
        BinaryNumericOperation op = CalculationService.Sum;
        result = op(a, b);
        result = op.Invoke(a, b); // is the same, but it's necessary to show that is possible
        Console.WriteLine($"BinaryNumericOperation op -> op(a, b): {result}");
    }
}
