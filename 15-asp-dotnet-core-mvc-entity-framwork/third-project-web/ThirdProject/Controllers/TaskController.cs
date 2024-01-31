using Microsoft.AspNetCore.Mvc;
using ThirdProject.Models.Enums;
using ThirdProject.Models.Dtos;

namespace ThirdProject.Controllers;

[ApiController]
[Route("api/tasks")]
public class TaskController : ControllerBase
{
    private static readonly List<Models.Task> _tasks = [];

    [HttpGet]
    public IActionResult FindAll() => Ok(_tasks);

    [HttpGet("{id}")]
    public IActionResult FindById(Guid id) => _tasks.Find(t => t.Id == id) != null
        ? Ok(_tasks.Find(t => t.Id == id))
        : NotFound();

    [HttpPost]
    public IActionResult Create(TaskDTO dto)
    {
        Models.Task newTask = new(dto.Title, dto.Description, dto.LimitDateTime);
        _tasks.Add(newTask);
        return Ok(newTask);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, TaskDTO dto)
    {
        int index = _tasks.FindIndex(task => task.Id == id);
        if (index == -1) return NotFound();
        _tasks[index].Title = dto.Title;
        _tasks[index].Description = dto.Description;
        _tasks[index].LimitDateTime = dto.LimitDateTime;
        return Ok(_tasks[index]);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        if (_tasks.Find(task => task.Id == id) == null) return NotFound();
        _tasks.RemoveAll(task => task.Id == id);
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult UpdateStatus(Guid id, Status status)
    {
        int index = _tasks.FindIndex(task => task.Id == id);
        if (index == -1) return NotFound();
        _tasks[index].Status = status;
        return Ok(_tasks[index]);
    }
}
