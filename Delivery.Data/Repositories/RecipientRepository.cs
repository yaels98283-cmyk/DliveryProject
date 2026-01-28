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
    public class RecipientRepository : IRecipientRespository
    {
        private readonly DataContext _context;

        public RecipientRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Recipients>> GetRecipientsAsync()
        {
            return await _context.recipients.Include(r => r.Packages).ToListAsync();

        }
        public async Task<Recipients> GetRecipientByIDAsync(int id)
        {
            return await _context.recipients.FirstAsync(x => x.Id == id);

        }
        public async Task<Recipients> AddRecipientAsync(Recipients recipient)
        {
            var r = await _context.recipients.FirstAsync(p => p.Id == recipient.Id);
            if (r == null)
            {
                _context.recipients.Add(recipient);

            }
            return r;
        }
        public async Task<Recipients> UpdateRecipientAsync(int id, Recipients recipient)
        {
            var r = await _context.recipients.FirstAsync(pac => pac.Id == recipient.Id);
            if (r != null)
            {
                r.Email = recipient.Email;
                r.Name = recipient.Name;
                r.Address = recipient.Address;
                r.PhoneNumber = recipient.PhoneNumber;
            }
            return r;
        }
        public async Task DeleteRecipientAsync(int id)
        {
            var d = await _context.recipients.FirstAsync(p => p.Id == id);
            if (d != null)
            {
                _context.recipients.Remove(d);
            }
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
