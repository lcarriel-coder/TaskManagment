
using Microsoft.AspNetCore.Mvc;
using Services.AppServices.Interfaces;
using Task_Managment.Commom.DTO;
using Task_Managment.Web.Controllers;

namespace Task_Managment.Controllers
{

    public class CategoryController : CustomBaseController
    {

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> Get()
        {
            var users = await _categoryService.GetCategories();
            return Ok(users);
        }


    }
}