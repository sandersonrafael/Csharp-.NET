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

var t1Less900 =
    from p in products
    where p.Category.Tier == 1 && p.Price < 900.0
    select p;

t1Less900.ToList().ForEach(Console.WriteLine);


Console.WriteLine("\nPRODUCT NAMES FROM TOOLS CATEGORY");

var toolsNames =
    from p in products
    where p.Category.Name == "Tools"
    select p.Name;

toolsNames.ToList().ForEach(Console.WriteLine);


Console.WriteLine("\nANONYMOUS OBJECTS FROM PRODUCTS WITH NAME STARTING WITH C CHARACTER");

var newObjFromStartWithC =
    from p in products
    where p.Name[0] == 'C'
    select new { p.Name, p.Price, Category = p.Category.Name };

newObjFromStartWithC.ToList().ForEach(Console.WriteLine);


Console.WriteLine("\nPRODUCTS WITH CATEGORY TIER = 1 AND SORTED BY PRICE");

var tier1OrderByPriceAndName =
    from p in products
    where p.Category.Tier == 1
    orderby p.Name // It is necessary to invert it to first order the name and then the prices (which is what you want)
    orderby p.Price
    select p;

tier1OrderByPriceAndName.ToList().ForEach(Console.WriteLine);


Console.WriteLine("\nSKIPPING 2 ITEMS AND TAKING FIRST 4");

var skip2Take4 =
    (from p in tier1OrderByPriceAndName
     select p)
    .Skip(2).Take(4).ToList();

skip2Take4.ForEach(Console.WriteLine);


Console.WriteLine("\nGROUP ELEMENTS BY CATEGORIES IN A NEW LIST");

var groupedBy =
    from p in products
    group p by p.Category;
foreach (IGrouping<Category, Product> group in groupedBy)
{
    Console.WriteLine($"\nCategory: {group.Key.Name}");
    foreach (Product item in group) Console.WriteLine(item);
}
