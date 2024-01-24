/* Extension Methods */

// They are methods that extend the functionality of a type, without changing the source code of that type or inheriting it
// Using extension methods, we can modify an Class to add a method, like that:

/* Example 1 */

using ExtensionMethodsCs.Extensions;

DateTime dt = new(2023, 11, 16, 8, 10, 45);

// ElapsedTime() is a method that don't exists in a DateTime object
// But using the namespace specified, it's possible to use now that method
Console.WriteLine(dt.ElapsedTime());

/* Example 2 */
// Using a extension method declared in namespace System instead of the directory it is in
// In this case, isn't necessary to use "using ...(namespace of extension class method)",
// because he is implemented in System namespace

string s2 = "Good morning dear students!";
Console.WriteLine(s2.Cut(10));
