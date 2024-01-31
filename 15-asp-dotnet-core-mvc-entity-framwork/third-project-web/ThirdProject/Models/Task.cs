using ThirdProject.Models.Enums;

namespace ThirdProject.Models;

public class Task(string title, string description, DateTime limitDateTime)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public DateTime LimitDateTime { get; set; } = limitDateTime;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Status Status { get; set; } = Status.CREATED;
}
