/* Steps in Practice */

// 1. Specify the data source
int[] numbers = [2, 3, 4, 5];

// 2. Define the query expression
// Ex: multiply all even numbers by 10
var result = numbers.Where(i => i % 2 == 0).Select(i => i * 10).ToList();

// 3. Execute the query
PrintArray(result);


// Query
static void PrintArray<T>(List<T> array)
{
    Console.Write('[');
    array.ForEach((item) => Console.Write($" {item} "));
    Console.WriteLine(']');
}
