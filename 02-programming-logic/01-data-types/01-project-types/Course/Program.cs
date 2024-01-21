using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            SByte x = 100; // in C# the type is sbyte, but in .NET it is SByte. In this case, it depends on importing System
            // The most commonly used integer numerics are int / System.Int32 and long / System.Int64
            // The most commonly used decimal numerics are float / System.Single and double / System.Double
            // When a decimal is required with a VERY large number, decimal is used / System.Decimal
            // Bool / System.Boolean are also very important

            Console.WriteLine(x);
            */

            // Overflow -> Calculates extrapolates the limit of the variable
            byte n1 = 255;
            n1++; // in this case, the value of the variable "resets", starting with the lowest possible value. As in byte it is 0
            // the value will be set to 0. If the lowest value was -128, it would be -128
            Console.WriteLine("\nValor de n1: " + n1 + "\n");

            int n2 = 1000;
            int n3 = 2147483647; // highest value of int
            long n4 = 2147483648L;

            System.Console.WriteLine(n2);
            System.Console.WriteLine(n3);
            System.Console.WriteLine(n4);

            bool ok = true;
            if (ok) System.Console.WriteLine(n1 + n2 + n3);

            char gender = 'F';
            System.Console.WriteLine(gender);

            float n5 = 4.5F;
            double n6 = 4.5D;

            string nome = "Mariana";

            System.Console.WriteLine(n5);
            System.Console.WriteLine(n6);
            System.Console.WriteLine(nome);


            /* Generics */
            Object fulano = "Rafael";
            var ciclano = "Jurandir";

            System.Console.WriteLine(fulano);
            System.Console.WriteLine(ciclano);

            /* Minimum and maximum values */

            // Type.MinValue -> returns the smallest value of the type
            // Type.MaxValue -> returns the largest value of the type

            int int1 = int.MinValue;
            int int2 = int.MaxValue;
            sbyte sbyte1 = sbyte.MinValue;
            decimal decimal1 = decimal.MaxValue;

            System.Console.WriteLine(
                "int1: " + int1 +
                "\nint2: " + int2 +
                "\nsbyte1: " + sbyte1 +
                "\ndecimal1: " + decimal1
            );
        }
    }
}
