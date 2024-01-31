using Microsoft.AspNetCore.Mvc;
using ThirdProject.Models.Enums;
using ThirdProject.Models.Dtos;
using ThirdProject.Services;

namespace ThirdProject.Controllers;

[ApiController]
[Route("api/tasks")]
public class TaskController : ControllerBase
{

    private readonly TaskService _service;

    public TaskController(TaskService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> FindAll() => Ok(await _service.FindAll());

    [HttpGet("{id}")]
    public async Task<IActionResult> FindById(Guid id)
    {
        TaskDTO? dtoTask = await _service.FindById(id);
        if (dtoTask is null) return NotFound();
        return Ok(dtoTask);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TaskDTO dto)
    {
        TaskDTO? dbDto = await _service.Create(dto);
        if (dbDto is null) return BadRequest();
        return Ok(dbDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, TaskDTO dto)
    {
        TaskDTO? dbDto = await _service.Update(id, dto);
        if (dbDto is null) return NotFound();
        return Ok(dbDto);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        TaskDTO? dbDto = await _service.Delete(id);
        if (dbDto is null) return NotFound();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateStatus(Guid id, Status status)
    {
        TaskDTO? dbDto = await _service.UpdateStatus(id, status);
        if (dbDto is null) return NotFound();
        return Ok(dbDto);
    }
}
