using BasonManagement.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasonManagement.Application.Interfaces.CacheRepositories
{
    public interface IProductCacheRepository
    {
        Task<List<Product>> GetCachedListAsync();

        Task<Product> GetByIdAsync(int brandId);
    }
}