using Delivery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Respositories
{
    public interface IUserRepository
    {
        public Task<User> GetByUserEmailAsync(string Email, string Password);
        public Task<User> AddUserAsync(User user);

    }
}
