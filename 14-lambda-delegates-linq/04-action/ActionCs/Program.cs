using ActionCs.Entities;

/* Action */

// Is a method that receive from 1 to 16 generic arguments and return void (just do an action)


List<Product> products = [new("TV", 900.0), new("Mouse", 50.0), new("Tablet", 350.50), new("HD Case", 80.90)];


// Action in ForEach Method
products.ForEach(UpdatePrice);
products.ForEach(Console.WriteLine);

static void UpdatePrice(Product p) => p.Price *= 1.1;
