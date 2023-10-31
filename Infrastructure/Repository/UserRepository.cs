using Task_Managment.Domain;
using Microsoft.AspNetCore.Identity;
using Task_Managment.Common.Interfaces;



namespace Task_Managment.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;


        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<User>> GetUsersAsync()
        {
   
            var getuser=  _userManager.Users.ToList();

            return getuser;

        }
    }
}
