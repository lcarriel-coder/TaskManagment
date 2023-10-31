using Task_Managment.Domain;

namespace Task_Managment.Common.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
    }
}
