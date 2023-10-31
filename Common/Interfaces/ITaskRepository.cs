using Task_Managment.Commom.DTO;
using Task = Task_Managment.Domain.Task;

namespace Task_Managment.Common.Interfaces
{
    public interface ITaskRepository
    {
        Task<string> Create(TaskSave model);
        Task<int> EditTask(TaskEdit model);
        Task<int> UpdateTaskIsComplete(IsComplete model);
        Task<PaginationModel<Task>> GetTaskByUser(GetTask model);
        Task<int> DeleteTask(Guid taskId);
    }
}
