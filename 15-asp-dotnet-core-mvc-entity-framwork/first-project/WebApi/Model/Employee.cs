using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace WebApi.Model;

[Table("employee")]
public class Employee
{
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("age")]
    public int Age { get; set; }

    [Column("photo")]
    public string? photo { get; private set; }

    public Employee(string name, int age, string? photo)
    {
        Name = name;
        Age = age;
        this.photo = photo;
    }
}
