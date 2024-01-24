/* Equals ad GetHashCode */

// Both are used to compare values
// Equals have a better precision, but whore performance
// GetHashCode have less precision, but a better performance

/* Equals */

// Do a direct comparison and return True if value is the same, and False if isn't the same

string a = "Maria";
string b = "Alex";

Console.WriteLine($"a.Equals(b): {a.Equals(b)}"); // False
Console.WriteLine($"a.Equals(a): {a.Equals(a)}"); // True


/* GetHashCode */

// Returns an int code that represents the variable
// The developer need to compare manually the HashCode of both variables

string c = "Maria";
string d = "maria";

Console.WriteLine($"c.GetHashCode(): {c.GetHashCode()}, d.GetHashCode(): {d.GetHashCode()}");
Console.WriteLine($"c.GetHashCode() == d.GetHashCode(): {c.GetHashCode() == d.GetHashCode()}");
Console.WriteLine($"c.GetHashCode() == 'Maria'.GetHashCode(): {c.GetHashCode() == "Maria".GetHashCode()}");

// Tips

// Never 2 objects with different HashCodes are the same
// In a big database, if you want to have a better performance, can be used a comparison like:

// First checks all values with a.GetHashCode() == listItem.GetHashCode()
// And if the value of then both are same, finally check e.Equals(listItem) // True or False
