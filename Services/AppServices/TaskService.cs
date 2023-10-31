using Services.AppServices.Interfaces;
using AutoMapper;
using Task_Managment.Commom.DTO;
using Task_Managment.Common.Interfaces;
using Task = Task_Managment.Domain.Task;

namespace Services.AppServices
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<string> Create(TaskSave model)
        {
            var save = await _taskRepository.Create(model);
           
            return save;

        }

        public async Task<int> EditTask(TaskEdit model)
        {
            var save = await _taskRepository.EditTask(model);

            return save;

        }

        public async Task<int> UpdateTaskIsComplete(IsComplete model)
        {
            var save = await _taskRepository.UpdateTaskIsComplete(model);
            return save;
        }
     
        public async Task<PaginationModel<TaskDto>> GetTaskByUser(GetTask model)
        {
            var getData = await _taskRepository.GetTaskByUser(model);
            var dataDto = _mapper.Map<PaginationModel<Task>, PaginationModel<TaskDto>>(getData);

            return dataDto;
        }

        public async Task<int> DeleteTask(Guid taskId)
        {
            var delete = await _taskRepository.DeleteTask(taskId);
            return delete;
        }
    }
}
