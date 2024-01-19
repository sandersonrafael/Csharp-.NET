using System;

namespace Lists {
    internal class Program {
        static void Main(string[] args) {
            /* Declaring Lists */

            // To declare a List, we need to inform the type inside a generic notation: List <Type>

            // The original empty list notation is: = new List<Type>(), but can be simplified to new()
            // And therefore can be easily initialized with just []
            List<string> list = new List<string>();
            list = new();
            list = [];

            // At the moment, we can initialize a List with values like:
            List<string> list2 = new List<string> { "ok", "ok2", "ok3" }; // or ->
            list2 = new() { "ok", "ok2", "ok3" }; // or ->
            list2 = ["ok", "ok2", "ok3"];
        }
    }
}
