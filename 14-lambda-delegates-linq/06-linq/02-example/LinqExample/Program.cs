using LinqExample.Entities;

Category c1 = new(1, "Tools", 2);
Category c2 = new(2, "Computers", 1);
Category c3 = new(3, "Electronics", 1);

List<Product> products = [
    new(1, "Computer", 1100.0, c2),
    new(2, "Hammer", 90.0, c1),
    new(3, "TV", 1700.0, c3),
    new(4, "Notebook", 1300.0, c2),
    new(5, "Saw", 80.0, c1),
    new(6, "Tablet", 700.0, c2),
    new(7, "Camera", 700.0, c3),
    new(8, "Printer", 350.0, c3),
    new(9, "MacBook", 1800.0, c2),
    new(10, "Sound Bar", 700.0, c3),
    new(11, "Level", 70.0, c1)
];


Console.WriteLine("TIER 1 AND PRICE < 900");

// Where -> Returns all products that satisfy a given condition
var t1Less900 = products.Where(p => p.Price < 900.0 && p.Category.Tier == 1).ToList();
t1Less900.ForEach(Console.WriteLine);


Console.WriteLine("\nPRODUCT NAMES FROM TOOLS CATEGORY");

// Select -> Returns the same number of items in list, but the item type and item content can be different
// Like Map method in JS
var toolsNames = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name).ToList();
toolsNames.ForEach(Console.WriteLine);


Console.WriteLine("\nANONYMOUS OBJECTS FROM PRODUCTS WITH NAME STARTING WITH C CHARACTER");

// Anonymous object with Select method and Lambda function
var newObjFromStartWithC = products.Where(p => p.Name[0] == 'C')
    .Select(p => new { p.Name, p.Price, Category = p.Category.Name }).ToList();

newObjFromStartWithC.ForEach(Console.WriteLine);


Console.WriteLine("\nPRODUCTS WITH CATEGORY TIER = 1 AND SORTED BY PRICE");

// OrderBy -> Returns the same list but ordered by informed attribute | Is ascending
// OrderByDescending -> The same, but ordered descending
// ThenBy -> Used after OrderBy to select a second attribute to sort when the first condition is equal for 2 or more items
var tier1OrderByPriceAndName = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name).ToList();
tier1OrderByPriceAndName.ForEach(Console.WriteLine);

Console.WriteLine("\nSKIPPING 2 ITEMS AND TAKING FIRST 4");

// Skip -> Skips a determined number of items in list
// Take -> Takes a determined number of items in list
var skip2Take4 = tier1OrderByPriceAndName.Skip(2).Take(4).ToList();
skip2Take4.ForEach(Console.WriteLine);

Console.WriteLine("\nTAKE THE FIRST ITEM IN LIST");

// First -> take the first item in list
// If First method is called when empty, it will throw a exception (InvalidOperationException)
// Instead, the FirstOrDefault method can be used -> if it finds no value, it returns null
var first = skip2Take4.First();
Console.WriteLine(first);

Console.WriteLine("\nTAKE A SINGLE ITEM OR DEFAULT VALUE NULL");

// SingleOrDefault -> Returns an item if the list have only one member. If have more than 1, it will thro exception
var singleElement = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine(singleElement);

Console.WriteLine("\nTAKE THE MAX VALUE OF LIST");

// Max -> Return the greater value (it's possible to inform a lambda function)
// To use Max() without arguments, it's necessary implements the interface IComparable in Product class
var max = products.Max();
Console.WriteLine(max);

Console.WriteLine("\nTAKE THE MIN VALUE OF LIST");

// Max -> Return the greater value (it's possible to inform a lambda function)
// To use Max() without arguments, it's necessary implements the interface IComparable in Product class
var min = products.Min();
Console.WriteLine(min);

Console.WriteLine("\nTAKE THE SUM OF ALL PRODUCTS PRICE OF CATEGORY WITH ID 1");

// Sum
double sum = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine($"{sum:F2}");

Console.WriteLine("\nTAKE THE AVERAGE OF ALL PRODUCTS PRICE OF CATEGORY WITH ID 1");

// Average
// double average = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
// Can throw error if the total length of list (where) is 0. To prevent that error, it's possible to do this:
double average = products.Where(p => p.Category.Id == 1).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine($"{average:F2}");


/* Aggregate (reduce in another languages) */

Console.WriteLine("\nCREATE A CUSTOM METHOD TO SUM ALL PRODUCT PRICES IN CATEGORY 1 WITH AGGREGATE");

// Aggregate -> can be invoked with 1 or 2 arguments
// If 1 -> (actualValue, accumulator) => {}
// If 2 -> (initial value, (actualValue, accumulator) => {}) | Can be used to prevent error when the select return less than 1 item
var aggregate = products.Where(p => p.Category.Id == 2).Select(p => p.Price).Aggregate(0.0, (actual, acc) => acc + actual);
Console.WriteLine(aggregate);


Console.WriteLine("\nGROUP ELEMENTS BY CATEGORIES IN A NEW LIST");

// GroupBy
var groupedBy = products.GroupBy(p => p.Category);
foreach (IGrouping<Category, Product> group in groupedBy)
{
    Console.WriteLine($"\nCategory: {group.Key.Name}");
    foreach (Product item in group)
    {
        Console.WriteLine(item);
    }
}
