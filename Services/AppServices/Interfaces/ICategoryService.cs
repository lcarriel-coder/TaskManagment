using Task_Managment.Commom.DTO;


namespace Services.AppServices.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetCategories();
    }
}
