using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Managment.Commom.DTO;
using Task_Managment.Domain;


namespace Services.AppServices.Interfaces
{
    public interface ITaskService
    {
        Task<string> Create(TaskSave model);
        Task<int> EditTask(TaskEdit model);
        Task<int> UpdateTaskIsComplete(IsComplete model);
        Task<int> DeleteTask(Guid taskId);
        Task<PaginationModel<TaskDto>> GetTaskByUser(GetTask model);
    }
}
