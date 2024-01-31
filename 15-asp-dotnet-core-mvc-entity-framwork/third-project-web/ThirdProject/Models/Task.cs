using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThirdProject.Models.Enums;

namespace ThirdProject.Models;

[Table("task")]
public class Task(string title, string description, DateTime limitDateTime)
{
    [Key, Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Column("title")]
    public string Title { get; set; } = title;

    [Column("description")]
    public string Description { get; set; } = description;

    [Column("limit_date_time")]
    public DateTime LimitDateTime { get; set; } = limitDateTime;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("status")]
    public Status Status { get; set; } = Status.CREATED;

    public override bool Equals(object? obj)
    {
        if (obj is not Models.Task) throw new InvalidOperationException("Invalid object to compare");
        Models.Task other = (Models.Task)obj;
        return Id.Equals(other.Id);
    }

    public override int GetHashCode() => Id.GetHashCode();
}
