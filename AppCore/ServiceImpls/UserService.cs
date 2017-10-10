using System.Collections.Generic;
using AppCore.Models;
using AppCore.Services;
using AutoMapper;
using com.VKB.AutoInject.Locators;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace AppCore.ServiceImpls
{
    [InjectTransient(typeof(IUserService))]
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _userRepository = repository;
            _mapper = mapper;
        }

        public IEnumerable<UserDto> GetAll()
        {
            IEnumerable<User> users = _userRepository.GetAll();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public UserDto Get(int id)
        {
            User user = _userRepository.Find(id);
            return _mapper.Map<UserDto>(user);
        }

        public bool Deactivate(UserDto userDto)
        {
            User user = _userRepository.Find(userDto.Id);
            if (user == null) return false;

            user.IsActive = false;
            _userRepository.Update(user);
            return true;
        }

        public bool Deactivate(int userId)
        {
            User user = _userRepository.Find(userId);
            if (user == null) return false;

            user.IsActive = false;
            _userRepository.Update(user);
            return true;
        }

        public void Update(UserDto userDto)
        {
            User user = _userRepository.Find(userDto.Id);
            _mapper.Map(userDto, user);
            _userRepository.Update(user);
        }
    }
}