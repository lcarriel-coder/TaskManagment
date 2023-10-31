using Task_Managment.Domain;
using Services.AppServices.Interfaces;
using AutoMapper;
using Task_Managment.Common.Interfaces;
using Task_Managment.Commom.DTO;

namespace Services.AppServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserBasicData>> GetUsersAsync()
        {
            var getUser = await _userRepository.GetUsersAsync();
            var dataDto = _mapper.Map<List<User>, List<UserBasicData>>(getUser);

            return dataDto;

        }
    }
}
