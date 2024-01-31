using System.Globalization;
using ThirdProject.Models.Enums;

namespace ThirdProject.Models.Requests;

public class TaskRequest(string title, string description, string createdAt, string limit, string status)
{
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public string CreatedAt { get; set; } = createdAt;
    public string Limit { get; set; } = limit;
    public string Status { get; set; } = status;
}
