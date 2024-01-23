string sourcePath = "./example.txt";
string targetPath = "./result.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using StreamWriter sw = File.AppendText(targetPath);
    lines.ToList().ForEach(line => sw.WriteLine(line.ToUpper()));
}
catch (IOException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
