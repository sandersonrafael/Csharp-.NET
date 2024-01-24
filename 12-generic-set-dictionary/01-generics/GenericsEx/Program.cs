using GenericsEx;

/* Generic Class */

PrintService<string> printService = new();

Console.Write("How many values you'll inform? ");
int quantity = int.Parse(Console.ReadLine() ?? "0");

for (int i = 0; i < quantity; i++)
{
    Console.Write($"Value {i + 1}: ");
    /* int */
    string x = /* int.Parse */(Console.ReadLine() ?? "0");
    printService.AddValue(x);
}

printService.Print();

Console.WriteLine($"\nFirst: {printService.First()}");


/* Generic Method */

string str = GenericMethod.ReturnSame("One string");
int integer = GenericMethod.ReturnSame(15);

Console.WriteLine($"str: '{str}'");
Console.WriteLine($"integer: {integer}");

string str1 = "Maria";
string str2 = "Felipe";

/* Generic Method Comparable */

string srtGreater = GenericMethod.ReturnGreater(str1, str2);

Console.WriteLine($"Greater({str1}/{str2}): {srtGreater}");

int int1 = 5;
int int2 = 10;

int intGreater = GenericMethod.ReturnGreater(int1, int2);

Console.WriteLine($"Greater({int1}/{int2}): {intGreater}");
