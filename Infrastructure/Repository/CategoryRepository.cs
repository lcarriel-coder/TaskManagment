using Task_Managment.Domain;

using Task_Managment.Common.Interfaces;
using Task_Managment.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Task_Managment.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseContext _context;


        public CategoryRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategories()
        {
   
            var getuser= await _context.Category.ToListAsync();

            return getuser;

        }
    }
}
