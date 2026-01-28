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
    public class DeliverService : IDeliverService
    {
        private readonly IDeliverRepository _deliverRepo;

        public DeliverService(IDeliverRepository deliverRepo)
        {
            _deliverRepo = deliverRepo;
        }
        public async Task<List<Delivers>> GetDeliversAsync()
        {
            return await _deliverRepo.GetDeliversAsync();
        }
        public async Task<Delivers> GetDeliverByIDAsync(int id)
        {
            return await _deliverRepo.GetDeliverByIDAsync(id);
        }
        public async Task<Delivers> AddDeliverAsync(Delivers deliver)
        {
            var d = await _deliverRepo.AddDeliverAsync(deliver);
            await _deliverRepo.SaveAsync();
            return d;

        }
        public async Task<Delivers> UpdateDeliverAsync(int id, Delivers deliver)
        {
            var d = await _deliverRepo.UpdateDeliverAsync(id, deliver);
            await _deliverRepo.SaveAsync();
            return d;

        }
        public async Task DeleteDeliverAsync(int id)
        {
            await _deliverRepo.DeleteDeliverAsync(id);
            await _deliverRepo.SaveAsync();

        }
    }
}
