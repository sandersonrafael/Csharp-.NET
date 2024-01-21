using Project;

ProductUnusual p1 = new("TV", 500.00, 3);
ProductCorret p2 = new("TV", 500.00, 3);

p1.SetName("TV 4K");
p2.Name = "TV 4K";

Console.WriteLine(p1.GetName());
Console.WriteLine(p2.Name);
