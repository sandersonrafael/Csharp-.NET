using ComparisonT.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 1500.00));
list.Add(new Product("Notebook", 2100.00));
list.Add(new Product("Tablet", 900.00));

// Delegate -> Reference for function with type safe
// The method Sort have a delegate modifier that allow's the developer to pass a function as an argument
// Isn't necessary to pass the arguments, just a method with the same types and structure that delegate one
// A lambda function is allowed as an argument of a Sort method or similar delegate methods
list.Sort((p1, p2) => p1.Name.ToLower().CompareTo(p2.Name.ToLower()));

list.ForEach(Console.WriteLine);
