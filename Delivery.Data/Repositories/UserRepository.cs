using Delivery.Core.Models;
using Delivery.Core.Respositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User> GetByUserEmailAsync(string Email, string Password)
        {
            return await _dataContext.users.FirstOrDefaultAsync(u => u.Email == Email && u.Password == Password);
        }

        public async Task<User> AddUserAsync(User user)
        {
            _dataContext.users.Add(user);
            //  await _dataContext.SaveChangesAsync();
            return user;
        }
        // צריך להוסיף מחיקה ועידכון
    }
}
