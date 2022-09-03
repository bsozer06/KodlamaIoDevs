using Core.Persistence.Repositories;
using KodlamaIoDevs.Application.Services.Repositorties;
using KodlamaIoDevs.Domain.Entities;
using KodlamaIoDevs.Persistance.Contexts;

namespace KodlamaIoDevs.Persistance.Repositories
{
    public class BrandsRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        public BrandsRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
