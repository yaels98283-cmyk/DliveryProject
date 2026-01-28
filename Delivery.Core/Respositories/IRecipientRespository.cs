using Delivery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Respositories
{
    public interface IRecipientRespository
    {
        public Task<List<Recipients>> GetRecipientsAsync();
        public Task<Recipients> GetRecipientByIDAsync(int id);

        public Task<Recipients> AddRecipientAsync(Recipients recipient);
        public Task<Recipients> UpdateRecipientAsync(int id, Recipients recipient);
        public Task DeleteRecipientAsync(int id);
        public Task SaveAsync();
    }
}
