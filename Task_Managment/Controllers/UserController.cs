
using Microsoft.AspNetCore.Mvc;
using Services.AppServices.Interfaces;
using Task_Managment.Commom.DTO;
using Task_Managment.Web.Controllers;

namespace Task_Managment.Controllers
{
 
    public class UserController : CustomBaseController
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserBasicData>>> GetUsers()
        {
            var users = await _userService.GetUsersAsync();
            return Ok(users);
        }


    }
}