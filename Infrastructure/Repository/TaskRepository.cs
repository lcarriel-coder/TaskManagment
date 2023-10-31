using Task_Managment.Domain;
using Microsoft.AspNetCore.Identity;
using Task_Managment.Common.Interfaces;
using Task_Managment.Infrastructure;
using Task_Managment.Commom.DTO;
using Microsoft.EntityFrameworkCore;
using Task = Task_Managment.Domain.Task;

namespace Task_Managment.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DatabaseContext _context;


        public TaskRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<string> Create(TaskSave model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

                var newTask = new Task
                {
                    Description = model.Description,
                    DeadlineToFinish = model.DeadlineToFinish,
                    UserId = model.UserId,
                    CategoryId = model.CategoryId,
                    IsCompleted = model.IsCompleted,
                    CreatedBy = model.UserId,
                    CreatedOn = DateTime.Now,
                    UpdatedBy = ""
                };

                _context.Task.Add(newTask);

            var save = await _context.SaveChangesAsync();
            if (save > 0) {
                return newTask.TaskId.ToString();
            }


            return "";
            

        }

        public async Task<int> EditTask(TaskEdit model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var tasksearch = _context.Task.Where(e => e.TaskId == model.TaskId).FirstOrDefault();
            if (tasksearch != null)
            {
                tasksearch.Description = model.Description;
                tasksearch.DeadlineToFinish = model.DeadlineToFinish;
                tasksearch.CategoryId = model.CategoryId;
                tasksearch.IsCompleted = model.IsCompleted;
                tasksearch.UpdatedOn = DateTime.Now;
            }


            var save = await _context.SaveChangesAsync();
            if (save > 0)
            {
                return save;
            }


            return 0;


        }

        public async Task<int> UpdateTaskIsComplete(IsComplete model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var getdata = _context.Task.Where(e => e.TaskId == model.TaskId).FirstOrDefault();

            if (getdata != null) {
                getdata.IsCompleted = model.IsCompleted;
            }

            var save = await _context.SaveChangesAsync();
            if (save > 0)
            {
                return save;
            }

            return 0;

        }

        public async Task<PaginationModel<Task_Managment.Domain.Task>> GetTaskByUser(GetTask model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var count = await _context.Task.Include(e=>e.Category)
                .Where(e => e.UserId == model.UserId && e.Category.Name.Contains(model.Filter == null ? "" : model.Filter))
                //.Where(e => e.UserId == model.UserId )
                .CountAsync();


            var getData = await _context.Task.Include(e => e.Category)
                                 .Where(e => e.UserId == model.UserId && e.Category.Name.Contains(model.Filter == null ? "" : model.Filter))
                                 //.Where(e => e.UserId == model.UserId)
                                .OrderByDescending(e => e.CreatedOn).Skip((model.PageNumber - 1) * model.PageSize).Take(model.PageSize).ToListAsync();


            PaginationModel<Task> data = new PaginationModel<Task> ();
            data.ListRecords = getData;
            data.TotalRecords = count;
            data.TotalPages = (int)Math.Ceiling(count / (double)model.PageSize);

            return data;


        }


        public async Task<int> DeleteTask(Guid taskId)
        {
            if (taskId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(taskId));
            }

            var getdata = _context.Task.Where(e => e.TaskId == taskId).FirstOrDefault();

            if (getdata != null)
            {
                _context.Remove(getdata);
            }

            var save = await _context.SaveChangesAsync();
            if (save > 0)
            {
                return save;
            }

            return 0;

        }
    }
}
