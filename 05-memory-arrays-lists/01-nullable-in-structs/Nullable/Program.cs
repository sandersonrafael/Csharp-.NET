using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {

            // Isn't possible to assign the "null" value to a struct (common variables)
            // double x = null; -> Error

            /* Solution */
            // Nullable<double> x = null; -> Correct, but legacy
            double? x = null;
            double? y = 10.0;

            /* Nullable methods */
            // The nullable variables have by default three methods / properties:

            // GetValueOrDefault() -> Take his value or give the default value for type (double is 0.0)
            // HasValue -> informs if the variable has a value or not
            // Value (throws exception if hasn't value)

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            // it's necessary to handle the possibile exception
            if (x.HasValue) Console.WriteLine(x.Value);
            else Console.WriteLine("X is null");
            Console.WriteLine(y.Value);

            /* Nullish Coalescing Operator */

            // Set to variable a "defined" default value if the informed value is null
            double? v = null;
            double t = v ?? 10.0;
            Console.WriteLine(t);
        }
    }
}
