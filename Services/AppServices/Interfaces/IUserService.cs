
using Task_Managment.Commom.DTO;

namespace Services.AppServices.Interfaces
{
    public interface IUserService
    {
        Task<List<UserBasicData>> GetUsersAsync();
    }
}
