using System.Collections;
using System.Collections.Generic;
using AppCore.Models;
using Infrastructure.Models;

namespace AppCore.Services
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAll();
        UserDto Get(int id);
        bool Deactivate(UserDto user);
        bool Deactivate(int userId);
        void Update(UserDto user);
    }
}