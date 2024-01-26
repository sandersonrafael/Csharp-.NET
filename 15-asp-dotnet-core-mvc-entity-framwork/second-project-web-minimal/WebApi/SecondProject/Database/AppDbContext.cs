using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using SecondProject.Model;

namespace SecondProject.Database;

// DbContext -> Create a connection with database
public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Database.sqlite");
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information); // Log relevant infos into the console
        //optionsBuilder.EnableSensitiveDataLogging(); // Allows to see in logger the variable values; Not recomended in production
    }
    // After this, it is necessary to create migrations -> Install Entity Framework Design as dependecy
    // Execute the comand: dotnet ef migrations add Initial

    // DbSet represents a table in a database
    public DbSet<Student> Students {  get; set; }
}
