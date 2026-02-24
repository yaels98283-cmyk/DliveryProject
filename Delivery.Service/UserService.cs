using Delivery.Core.Models;
using Delivery.Core.Respositories;
using Delivery.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetByUserEmailAsync(string Email, string Password)
        {
            return await _userRepository.GetByUserEmailAsync(Email, Password);
        }

        public async Task<User> AddUserAsync(User user)
        {
            return await _userRepository.AddUserAsync(user);
        }
    }
}
