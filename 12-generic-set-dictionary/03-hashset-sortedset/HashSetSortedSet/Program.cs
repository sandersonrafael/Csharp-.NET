/* HashSet && SortedSet */

// Represents a set of elements (similar to algebra)
// Don't alow repetitions
// No positions defined
// Fast access, insertion and remotion of elements
// Offer efficient set operations: intersection, union and difference

/* HashSet */

// Hash table storage
// Extremely fast: O(1) insertion, removal and search
// The order of elements is not guaranteed

/* SortedSet */

// Tree storage
// Fast: insertion, removal and search O(log(n))
// Elements are stored in order according to the IComparer<T> implementation

/* Methods */

// Add
// Clear
// Contains
// UnionWith(other)
// IntersectWith(other)
// ExceptWith(other)
// Remove(T)
// RemoveWHere(predicate)


/* HashSet Example */

HashSet<string> stringSet = new HashSet<string>();

stringSet.Add("TV");
stringSet.Add("Notebook");
stringSet.Add("Tablet");

Console.WriteLine("stringSet: ");
PrintCollection(stringSet);

Console.WriteLine($"stringSet.Contains(\"Notebook\"): {stringSet.Contains("Notebook")}");
Console.WriteLine($"stringSet.Contains(\"Computer\"): {stringSet.Contains("Computer")}");


/* SortedSet Example */

SortedSet<int> intSetA = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
SortedSet<int> intSetB = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

Console.WriteLine("\nintSetA: ");
PrintCollection(intSetA);

Console.WriteLine("intSetB: ");
PrintCollection(intSetB);

// Union
SortedSet<int> intSetC = new SortedSet<int>(intSetA);
Console.WriteLine("intSetC: // Union ");
intSetC.UnionWith(intSetB);
PrintCollection(intSetC);

// Intersection
SortedSet<int> intSetD = new SortedSet<int>(intSetA);
Console.WriteLine("intSetD: // Intersection ");
intSetD.IntersectWith(intSetB);
PrintCollection(intSetD);

// Difference
SortedSet<int> intSetE = new SortedSet<int>(intSetA);
Console.WriteLine("intSetE: // Difference ");
intSetE.ExceptWith(intSetB);
PrintCollection(intSetE);

// IEnumerable is an Interface implemented by all collections from System.Collections.Generic
static void PrintCollection<T>(IEnumerable<T> collection)
{
    Console.Write('[');
    foreach (T item in collection)
    {
        Console.Write($" {item} ");
    }
    Console.Write("]\n\n");
}
