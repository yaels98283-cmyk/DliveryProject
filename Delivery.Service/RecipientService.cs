using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Core.Respositories;
using Delivery.Core.Models;
using Delivery.Core.Services;

namespace Delivery.Service
{
    public class RecipientService : IRecipientService
    {
        private readonly IRecipientRespository _recipientRepo;
        public RecipientService(IRecipientRespository recipientRepo)
        {
            _recipientRepo = recipientRepo;
        }
        public async Task<List<Recipients>> GetRecipientsAsync()
        {
            return await _recipientRepo.GetRecipientsAsync();
        }
        public async Task<Recipients> GetRecipientByIDAsync(int id)
        {
            return await _recipientRepo.GetRecipientByIDAsync(id);
        }
        public async Task<Recipients> AddRecipientAsync(Recipients recipient)
        {
            var r = await _recipientRepo.AddRecipientAsync(recipient);
            await _recipientRepo.SaveAsync();
            return r;
        }
        public async Task<Recipients> UpdateRecipientAsync(int id, Recipients recipient)
        {
            var r = await _recipientRepo.UpdateRecipientAsync(id, recipient);
            await _recipientRepo.SaveAsync();
            return r;

        }
        public async Task DeleteRecipientAsync(int id)
        {
            await _recipientRepo.DeleteRecipientAsync(id);
            await _recipientRepo.SaveAsync();

        }
    }
}
