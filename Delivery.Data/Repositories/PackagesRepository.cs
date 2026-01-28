using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Core.Respositories;
using Delivery.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Repositories
{
    public class PackagesRepository : IPackagesRespository
    {
        private readonly DataContext _context;
        public PackagesRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Packages>> GetPackagesAsync()
        {
            return await _context.packages.Include(p => p.Deliver).Include(p => p.recipient).ToListAsync();

        }
        public async Task<Packages> GetPackageByIDAsync(int code)
        {
            var p = await _context.packages.FirstAsync(x => x.Id == code);
            if (p == null)
                return null;
            return p;

        }
        public async Task<Packages> AddPackageAsync(Packages package)
        {
            var d = await _context.packages.FirstAsync(p => p.Id == package.Id);
            if (d == null)
            {
                _context.packages.Add(d);

            }
            return d;
        }
        public async Task<Packages> UpdatePackagesAsync(int code, Packages package)
        {
            var p = await _context.packages.FirstAsync(pac => pac.Id == package.Id);
            if (p != null)
            {
                p.DeliverID = package.DeliverID;
                p.RecipientID = package.RecipientID;
                p.Description = package.Description;
                p.Status = package.Status;
            }
            return p;
        }

        public async Task DeletePackageAsync(int code)
        {
            var p = await _context.packages.FirstAsync(p => p.Id == code);
            if (p != null)
            {
                _context.packages.Remove(p);
            }
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
