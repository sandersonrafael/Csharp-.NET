using PredicateCs.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.0));
list.Add(new Product("Mouse", 50.0));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

/* Predicate */

list.RemoveAll(ProductLess100);
list.ForEach(Console.WriteLine);



// A predicate method receive a generic value as argument and return boolean as result
static bool ProductLess100(Product p)
{
    return p.Price >= 100.0;
}
