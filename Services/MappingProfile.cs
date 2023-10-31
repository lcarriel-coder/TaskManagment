using Task_Managment.Domain;
using AutoMapper;
using Task_Managment.Commom.DTO;
using Task = Task_Managment.Domain.Task;

namespace Task_Managment.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserBasicData>();
            CreateMap<Category, CategoryDto>();

            CreateMap<Task, TaskDto>()
                      .ForMember(p => p.CategoryName, o => o.MapFrom(src => src.Category.Name)); ;
            CreateMap<PaginationModel<Task>, PaginationModel<TaskDto>>();
          

          

        }

    }
}
