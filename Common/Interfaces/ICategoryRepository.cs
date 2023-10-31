using Task_Managment.Domain;

namespace Task_Managment.Common.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategories();
    }
}
