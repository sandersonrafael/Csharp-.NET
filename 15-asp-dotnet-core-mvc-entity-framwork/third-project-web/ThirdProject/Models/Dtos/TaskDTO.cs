namespace ThirdProject.Models.Dtos;

public class TaskDTO(string title, string description, DateTime limitDateTime)
{
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public DateTime LimitDateTime { get; set; } = limitDateTime;
}
