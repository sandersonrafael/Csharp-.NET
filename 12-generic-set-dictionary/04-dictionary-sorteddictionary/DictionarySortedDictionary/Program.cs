/* Dictionary && SortedDictionary */

// In another languages, is commonly called by Map
// Is a generic collection that receives a pair of key and value, by different (optional) types both
// The key can't be repeated
// Elements indexed by they key (they don't have specified position)
// Fast access, insertion and remotion of elements

/* Dictionary */

// Stores in a hash table
// Extremely fast / Insertion, remotion and search in O(1)
// Element order don't be granted


/* SortedDictionary */

// Stores in a tree
// Fast / Insertion, remotion and search in O(log(n))
// The elements are stored in order according to the IComparer<T> implementation

/* Methods */

// Add(key, value)
// Clear()
// Count
// ContainsKey(key)
// ContainsValue(value)
// Remove(key)

Dictionary<string, string> cookies = new Dictionary<string, string>();

// It's possible to add and access values with brackets notation too

cookies["user"] = "Maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "12345678910";
cookies["phone"] = "98765432101"; // override

Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

cookies.Remove("user");

if (cookies.ContainsKey("user")) Console.WriteLine(cookies["user"]);
else Console.WriteLine("Key \"user\" don't exists in Dictionary");

Console.WriteLine($"cookies.Count: {cookies.Count}");

Console.WriteLine("Dictionary pairs: ");
Console.Write('[');
foreach (KeyValuePair<string, string> item in cookies)
{
    Console.Write($" \"{item.Key}\": \"{item.Value}\" ");
}
Console.WriteLine(']');
