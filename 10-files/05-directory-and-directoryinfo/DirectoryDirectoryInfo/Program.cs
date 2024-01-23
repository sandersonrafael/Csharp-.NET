/* Directory */

// Similar to File in characteristics -> Static methods can be used, no instantiating
// May cause performance problem

/* DirectoryInfo */

// Similar to FileInfo in characteristics -> Instantiated objects / no constant security checks
// Better performance

string path = "./obj";

try
{
    // List all folders
    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Folders: ");
    folders.ToList().ForEach(Console.WriteLine);

    // List all files
    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("\nFiles: ");
    files.ToList().ForEach(Console.WriteLine);

    // Create a directory
    Directory.CreateDirectory($"{path}/newFolder");
}
catch (IOException e)
{
    Console.WriteLine($"Error: {e}");
}
