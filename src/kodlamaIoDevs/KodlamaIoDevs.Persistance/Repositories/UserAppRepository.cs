using Core.Persistence.Repositories;
using KodlamaIoDevs.Application.Services.Repositorties;
using KodlamaIoDevs.Domain.Entities;
using KodlamaIoDevs.Persistance.Contexts;

namespace KodlamaIoDevs.Persistance.Repositories
{
    public class UserAppRepository : EfRepositoryBase<UserApp, BaseDbContext>, IUserAppRepository
    {
        public UserAppRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
