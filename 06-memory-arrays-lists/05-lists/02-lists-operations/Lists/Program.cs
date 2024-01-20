using System;

namespace Lists {
    internal class Program {
        static void Main(string[] args) {
            /* List Methods && Attributes */
            List<string> list = new List<string>();

            /* Add */

            // Add -> The Add method insert an item in the last position
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            // Insert -> This method add an item in a specified position
            list.Insert(2, "Luiz");

            Console.Write("List: [");
            list.ForEach(item => Console.Write($" {item} "));
            Console.WriteLine("]");

            // Count -> Attributes that shows the list length
            Console.WriteLine($"Total items: {list.Count}");

            /* Find */

            // Find -> Return a Item (or null) that satisfies a boolean condition
            string? person1 = list.Find(item => item[0] == 'M');
            Console.WriteLine($"First starting with 'M': {person1}");

            // FindLast -> the same of Find, but return the last occurrence of the condition
            string? person2 = list.FindLast(item => item[0] == 'A');
            Console.WriteLine($"Last starting with 'A': {person2}");

            // FindIndex -> Return the index (or -1) of an Item that satisfies a boolean condition
            int position1 = list.FindIndex(item => item[0] == 'J');
            Console.WriteLine($"First index starting with 'J': {position1}");

            // FindLastIndex -> the same of FindIndex, but return the last occurrence of the condition
            int position2 = list.FindLastIndex(item => item[0] == 'A');
            Console.WriteLine($"Last index starting with 'A': {position2}");

            // FindAll -> Returns a new List containing all members that satisfies the condition
            List<string> newList = list.FindAll(item => item.Length >= 4);
            Console.Write("New List (items that have 4 or more characters): [");
            newList.ForEach(item => Console.Write($" {item} "));
            Console.WriteLine("]");

            /* Remove */

            // Remove -> removes an item equal to the one given
            list.Remove("Alex");

            Console.Write("List without 'Alex': [");
            list.ForEach(item => Console.Write($" {item} "));
            Console.WriteLine("]");

            // RemoveALl -> removes everyone who meets the given condition
            list.RemoveAll(item => item[0] == 'A');

            Console.Write("List without anyone that starts with 'A': [");
            list.ForEach(item => Console.Write($" {item} "));
            Console.WriteLine("]");

            // RemoveAt -> removes the item at the specified position (index)
            list.RemoveAt(0);

            Console.Write("List without index 0: [");
            list.ForEach(item => Console.Write($" {item} "));
            Console.WriteLine("]");

            // RemoveRange -> removes all items starting at the first argument and one less of the second argument
            list.RemoveRange(0, 2);

            Console.Write("List without range items (0, 2) or without item 0 and item 1: [");
            list.ForEach(item => Console.Write($" {item} "));
            Console.WriteLine("]");
        }
    }
}
