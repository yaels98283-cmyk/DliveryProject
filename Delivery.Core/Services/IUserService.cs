using Delivery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Services
{
    public interface IUserService
    {
        public Task<User> GetByUserEmailAsync(string Email, string Password);
        public Task<User> AddUserAsync(User user);
    }
}
