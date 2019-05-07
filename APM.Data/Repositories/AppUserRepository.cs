using APM.Data.Infrastructure;
using APM.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM.Data.Repositories
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
    }
    public class AppUserRepository : RepositoryBase<AppUser>, IAppUserRepository
    {
        public AppUserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
