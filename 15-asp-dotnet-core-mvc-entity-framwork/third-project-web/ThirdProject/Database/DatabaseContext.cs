using Microsoft.EntityFrameworkCore;
using ThirdProject.Models.Enums;

namespace ThirdProject.Database;

public class DatabaseContext : DbContext
{
    private readonly IConfiguration _configuration;
    private readonly string? _connectionString;

    public DbSet<Models.Task> Tasks { get; set; }

    public DatabaseContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("Default");
    }

    // Handle String Enums in MySQL
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.Task>()
            .Property(entity => entity.Status)
            .HasConversion<string>();
        //base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(_connectionString ?? "");
    }
}
