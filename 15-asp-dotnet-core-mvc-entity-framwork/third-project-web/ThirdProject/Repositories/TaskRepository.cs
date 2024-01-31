using Microsoft.EntityFrameworkCore;
using ThirdProject.Database;
using ThirdProject.Models.Enums;
using ThirdProject.Repositories.Interfaces;

namespace ThirdProject.Repositories;

public class TaskRepository : ITaskRepository
{

    private readonly DatabaseContext _context;

    public TaskRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<Models.Task>> FindAll() => await _context.Tasks.ToListAsync();

    public async Task<Models.Task?> FindById(Guid id) => await _context.Tasks.FirstOrDefaultAsync(tk => tk.Id == id);

    public async Task<Models.Task?> Create(Models.Task task)
    {
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();
        return task;
    }

    public async Task<Models.Task?> Update(Models.Task task)
    {
        Models.Task? dbTask = await _context.Tasks.FirstOrDefaultAsync(tk => tk.Id == task.Id);
        if (dbTask is null) return null;
        dbTask = task;
        await _context.SaveChangesAsync();
        return dbTask;
    }

    public async Task<Models.Task?> Delete(Guid id)
    {
        List<Models.Task> dbTasks = await _context.Tasks.ToListAsync();
        Models.Task? taskToDelete = dbTasks.FirstOrDefault(tk => tk.Id == id);
        dbTasks.RemoveAll(task => task.Equals(taskToDelete));
        await _context.SaveChangesAsync();
        return taskToDelete;
    }

    public async Task<Models.Task?> UpdateStatus(Guid id, Status status)
    {
        Models.Task? dbTask = await _context.Tasks.FirstOrDefaultAsync(task => task.Id == id);
        if (dbTask is null) return null;
        dbTask.Status = status;
        await _context.SaveChangesAsync();
        return dbTask;
    }
}
