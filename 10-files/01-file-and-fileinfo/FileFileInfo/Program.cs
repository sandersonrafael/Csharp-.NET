// In windows, can be used like @"c:\selected\path" instead of "c:\\selected\\path"
string sourcePath = "./example.txt";
string targetPath = "./result.txt";

try
{
    /* FileInfo */

    // Faster, with a better performance, but need to be instantiated
    // Security operations don't need to occur in all uses
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath); // Copy a file

    /* File */

    // Slowest, with worse performance, but don't need to be instantiated
    // Security operations hate to occur in every use
    // All of his use are static
    string[] lines = File.ReadAllLines(sourcePath);
    lines.ToList().ForEach(Console.WriteLine);
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}
