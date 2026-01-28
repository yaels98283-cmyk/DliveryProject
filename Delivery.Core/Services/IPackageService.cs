using Delivery.Core.Services;
using Delivery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Services
{
    public interface IPackageService
    {
        public Task<List<Packages>> GetPackagesAsync();
        public Task<Packages> GetPackageByIDAsync(int code);

        public Task<Packages> AddPackageAsync(Packages package);
        public Task<Packages> UpdatePackagesAsync(int code, Packages package);
        public Task DeletePackageAsync(int code);
    }
}
