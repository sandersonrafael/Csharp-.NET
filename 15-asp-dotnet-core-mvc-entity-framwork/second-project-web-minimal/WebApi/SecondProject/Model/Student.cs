using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondProject.Model;

[Table("student")]
public class Student
{
    // Using init instead set, the propertie don't be modified anymore
    // Used to perperties like Id, that never be changed
    [Key]
    [Column("id")]
    public Guid Id { get; init; }

    [Column("name")]
    public string Name { get; private set; }

    // The column annotation can receive the column name as first argument and TypeName = "TYPE_IN_SQL" for the second
    [Column("active", TypeName = "BOOLEAN")]
    public bool Active { get; private set; }

    // To generate migrations, just run command dotnet ef migrations add MigrationName
    // After, to update, run command: dotnet ef database update
    public Student(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        Active = true;
    }

    public void UpdateName(string name) => Name = name;

    public void TurnInactive() => Active = false;
}
