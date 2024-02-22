using System;
using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DevFreelaDbContext devFreelaDbContext) : base(devFreelaDbContext)
        {
        }
    }
}

