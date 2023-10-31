using Task_Managment.Domain;
using Services.AppServices.Interfaces;
using AutoMapper;
using Task_Managment.Common.Interfaces;
using Task_Managment.Commom.DTO;

namespace Services.AppServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryDto>> GetCategories()
        {
            var getCategories= await _categoryRepository.GetCategories();
            var dataDto = _mapper.Map<List<Category>, List<CategoryDto>>(getCategories);

            return dataDto;

        }
    }
}
