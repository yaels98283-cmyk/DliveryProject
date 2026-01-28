using Delivery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Services
{
    public interface IDeliverService
    {
        public Task<List<Delivers>> GetDeliversAsync();
        public Task<Delivers> GetDeliverByIDAsync(int id);
        public Task<Delivers> AddDeliverAsync(Delivers deliver);
        public Task<Delivers> UpdateDeliverAsync(int id, Delivers deliver);
        public Task DeleteDeliverAsync(int id);
    }
}
