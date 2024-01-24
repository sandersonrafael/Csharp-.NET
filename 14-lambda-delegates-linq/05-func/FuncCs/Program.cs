using FuncCs.Entities;

/* Func */

// Represents a delegate method that receive from 0 to 16 generic arguments and return some value


List<Product> products = [new("TV", 900.0), new("Mouse", 50.0), new("Tablet", 350.50), new("HD Case", 80.90)];

// Linq function select
// Select is similar to List.Map(...) method in JS or Java
// Need to turn in a List in final because he returns a IEnumerable
List<string> result = products.Select(p => p.Name.ToUpper()).ToList();
result.ForEach(Console.WriteLine);
