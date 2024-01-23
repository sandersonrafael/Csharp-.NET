try
{
    int n1 = 10;
    int n2 = 0;

    int result = n1 / n2;

    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("DividedByZeroException ocurred");
}
finally
{
    Console.WriteLine("Reached the finally block");
}
