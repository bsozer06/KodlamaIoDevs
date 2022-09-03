using Core.Persistence.Repositories;
using KodlamaIoDevs.Domain.Entities;

namespace KodlamaIoDevs.Application.Services.Repositorties
{
    public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
    {
    }
}
