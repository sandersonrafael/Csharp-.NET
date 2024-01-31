using ThirdProject.Models.Enums;

namespace ThirdProject.Models.Dtos;

public class TaskDTO(Guid id, string title, string description, DateTime limitDateTime, Status status)
{
    public Guid Id { get; set; } = id;
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public DateTime LimitDateTime { get; set; } = limitDateTime;
    public Status Status { get; set; } = status;
}
