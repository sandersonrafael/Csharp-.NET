string path = "./example.txt";
// FileStream? fs = null;
StreamReader? sr = null;

// Instead of this notation, we can use direct the Class File and method OpenText to use this same resource

try
{
    // fs = new FileStream(path, FileMode.Open);
    // sr = new StreamReader(fs);
    sr = File.OpenText(path);
    string? line;

    while (!sr.EndOfStream)
    {
        line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
finally
{
    // fs?.Close();
    sr?.Close();
}
