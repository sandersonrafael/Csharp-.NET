using System.Globalization;
using IComparableExample.Entities;

string people = "./people.txt";
string employees = "./employees.txt";

try
{
    using StreamReader sr = File.OpenText(people);

    List<string> list = [];

    while (!sr.EndOfStream)
    {
        string? line = sr.ReadLine();
        if (line != null) list.Add(line);
    }

    list.Sort();
    Console.WriteLine("People ordered by name: ");
    list.ForEach(Console.WriteLine);

    using StreamReader sr2 = File.OpenText(employees);

    List<Employee> allEmployees = [];
    while (!sr2.EndOfStream)
    {
        string[] infos = (sr2.ReadLine() ?? "").Split(",");
        string name = infos[0];
        double salary = double.Parse(infos[1], CultureInfo.InvariantCulture);
        allEmployees.Add(new(name, salary));
    }

    allEmployees.Sort();
    allEmployees.Reverse();
    Console.WriteLine("\nEmployees ordered by greater salary:");
    allEmployees.ForEach(Console.WriteLine);
}
catch (IOException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
