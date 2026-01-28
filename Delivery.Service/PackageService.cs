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
    public class PackageService : IPackageService
    {
        private readonly IPackagesRespository _packageRepo;

        public PackageService(IPackagesRespository packageRepo)
        {
            _packageRepo = packageRepo;
        }
        public async Task<List<Packages>> GetPackagesAsync()
        {
            return await _packageRepo.GetPackagesAsync();
        }
        public async Task<Packages> GetPackageByIDAsync(int code)
        {
            return await _packageRepo.GetPackageByIDAsync(code);
        }
        public async Task<Packages> AddPackageAsync(Packages package)
        {
            var p = await _packageRepo.AddPackageAsync(package);
            await _packageRepo.SaveAsync();
            return p;

        }
        public async Task<Packages> UpdatePackagesAsync(int id, Packages package)
        {
            var p = await _packageRepo.UpdatePackagesAsync(id, package);
            await _packageRepo.SaveAsync();
            return p;
        }
        public async Task DeletePackageAsync(int code)
        {
            await _packageRepo.DeletePackageAsync(code);
            await _packageRepo.SaveAsync();

        }
    }
}
