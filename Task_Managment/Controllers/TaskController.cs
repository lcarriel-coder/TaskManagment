
using Microsoft.AspNetCore.Mvc;
using Services.AppServices.Interfaces;
using Task_Managment.Commom.DTO;
using Task_Managment.Web.Controllers;

namespace Task_Managment.Controllers
{
    public class TaskController : CustomBaseController
    {

        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

    

        [HttpPost("Create")]
        public async Task<IActionResult> Create(TaskSave model)
        {
            if (!ModelState.IsValid)
            {

                return BadRequest();
            }

            try
            {
                var createTask = await _taskService.Create(model);
                return Ok(createTask);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }


        [HttpPut("EditTask")]
        public async Task<IActionResult> EditTask(TaskEdit model)
        {
            if (!ModelState.IsValid)
            {

                return BadRequest();
            }

            try
            {
                var createTask = await _taskService.EditTask(model);
                return Ok("La solicitud se procesó correctamente.");
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        [HttpPut("UpdateTaskIsComplete")]
        public async Task<IActionResult> UpdateTaskIsComplete(IsComplete model)
        {
            if (!ModelState.IsValid)
            {

                return BadRequest();
            }

            try
            {
                var createTask = await _taskService.UpdateTaskIsComplete(model);
                return Ok("La solicitud se procesó correctamente.");
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }


        [HttpDelete("DeleteTask/{taskId}")]
        public async Task<IActionResult> DeleteTask(string taskId)
        {
            if (string.IsNullOrEmpty(taskId))
            {
                return BadRequest("El taskId no puede ser vacío.");
            }
            try
            {
                var guidconvert = new Guid(taskId);
                var deleteTask = await _taskService.DeleteTask(guidconvert);
                return Ok("La solicitud se procesó correctamente.");
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }


        [HttpGet]
        public async Task<ActionResult<PaginationModel<TaskDto>>> Get([FromQuery] GetTask model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var getTasks = await _taskService.GetTaskByUser(model);

                return getTasks;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }


    }
}