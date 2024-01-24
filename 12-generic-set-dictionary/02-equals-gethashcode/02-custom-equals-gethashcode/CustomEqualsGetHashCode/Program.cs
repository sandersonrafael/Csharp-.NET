using CustomEqualsGetHashCode.Entities;

Customer a = new("Maria", "maria@gmail.com");
Customer b = new("Alex", "maria@gmail.com");

Console.WriteLine($"a.Equals(b): {a.Equals(b)}");
Console.WriteLine($"a == b: {a == b}");
Console.WriteLine($"a.GetHashCode(): {a.GetHashCode()}");
Console.WriteLine($"b.GetHashCode(): {b.GetHashCode()}");
