using ThirdProject.Models.Dtos;
using ThirdProject.Models.Enums;

namespace ThirdProject.Repositories.Interfaces;

public interface ITaskRepository
{
    Task<List<Models.Task>> FindAll();
    Task<Models.Task?> FindById(Guid id);
    Task<Models.Task?> Create(Models.Task task);
    Task<Models.Task?> Update(Models.Task task);
    Task<Models.Task?> Delete(Guid id);
    Task<Models.Task?> UpdateStatus(Guid id, Status status);
}
