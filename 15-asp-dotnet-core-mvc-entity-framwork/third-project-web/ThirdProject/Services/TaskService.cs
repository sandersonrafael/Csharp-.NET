using ThirdProject.Models.Dtos;
using ThirdProject.Models.Enums;
using ThirdProject.Repositories;
using ThirdProject.Repositories.Interfaces;

namespace ThirdProject.Services;

public class TaskService
{
    private readonly ITaskRepository _repository;

    public TaskService(ITaskRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<TaskDTO>> FindAll()
    {
        var list = await _repository.FindAll();
        return list.Select(task => new TaskDTO(task.Id, task.Title, task.Description, task.LimitDateTime, task.Status)).ToList();
    } 

    public async Task<TaskDTO?> FindById(Guid id)
    {
        Models.Task? dbTask = await _repository.FindById(id);
        if (dbTask is null) return null;
        return new TaskDTO(dbTask.Id, dbTask.Title, dbTask.Description, dbTask.LimitDateTime, dbTask.Status);
    }

    public async Task<TaskDTO?> Create(TaskDTO dto)
    {
        Models.Task? dbTask = await _repository.Create(new Models.Task(dto.Title, dto.Description, dto.LimitDateTime));
        if (dbTask is null) return null;
        return new TaskDTO(dbTask.Id, dbTask.Title, dbTask.Description, dbTask.LimitDateTime, dbTask.Status);
    }

    public async Task<TaskDTO?> Update(Guid id, TaskDTO dto)
    {
        Models.Task? dbTask = await _repository.FindById(id);
        if (dbTask is null) return null;

        dbTask.Title = dto.Title;
        dbTask.Description = dto.Description;
        dbTask.LimitDateTime = dto.LimitDateTime;

        await _repository.Update(dbTask);
        return new TaskDTO(dbTask.Id, dbTask.Title, dbTask.Description, dbTask.LimitDateTime, dbTask.Status);
    }

    public async Task<TaskDTO?> Delete(Guid id)
    {
        Models.Task? deletedTask = await _repository.Delete(id);
        if (deletedTask is null) return null;
        return new TaskDTO(deletedTask.Id, deletedTask.Title, deletedTask.Description, deletedTask.LimitDateTime, deletedTask.Status);
    }

    public async Task<TaskDTO?> UpdateStatus(Guid id, Status status)
    {
        Models.Task? updatedStatusTask = await _repository.UpdateStatus(id, status);
        if (updatedStatusTask is null) return null;
        return new TaskDTO(
            updatedStatusTask.Id,
            updatedStatusTask.Title,
            updatedStatusTask.Description,
            updatedStatusTask.LimitDateTime,
            updatedStatusTask.Status
        );
    }
}
