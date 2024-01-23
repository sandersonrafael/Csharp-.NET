/* Using Block */

// It is a simplification to use IDisposable objects (the objects that need to be manually closed)
// Ex: Font, FileStream, StreamReader, StreamWriter etc.


try
{
    string path = "./example.txt";

    // using FileStream fs = new(path, FileMode.Open);
    // using StreamReader sr = new(fs);

    // Simplifying
    using StreamReader sr = File.OpenText(path);

    string? line;
    while (!sr.EndOfStream)
    {
        line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine($"Error: {e}");
}
