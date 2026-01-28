using Delivery.Core.Respositories;
using Delivery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Repositories
{
    public class DeliversRepository : IDeliverRepository
    {
        private readonly DataContext _context;

        public DeliversRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Delivers>> GetDeliversAsync()
        {
            return await _context.delivers.Include(d => d.Packages).ToListAsync();

        }
        public async Task<Delivers> GetDeliverByIDAsync(int id)
        {
            return await _context.delivers.FirstAsync(x => x.Id == id);

        }
        public async Task<Delivers> AddDeliverAsync(Delivers deliver)
        {
            var d = await _context.delivers.FirstAsync(p => p.Id == deliver.Id);
            if (d == null)
            {
                _context.delivers.Add(deliver);

            }
            return d;
        }
        public async Task<Delivers> UpdateDeliverAsync(int id, Delivers deliver)
        {
            var d = await _context.delivers.FirstAsync(pac => pac.Id == deliver.Id);
            if (d != null)
            {
                d.Email = deliver.Email;
                d.Name = deliver.Name;
                d.Address = deliver.Address;
                d.PhoneNumber = deliver.PhoneNumber;
            }
            return d;
        }
        public async Task DeleteDeliverAsync(int id)
        {
            var d = await _context.delivers.FirstAsync(p => p.Id == id);
            if (d != null)
            {
                _context.delivers.Remove(d);
            }
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
