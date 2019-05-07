using APM.Data.Infrastructure;
using APM.Entity.Models;

namespace APM.Data.Repositories
{
    public interface IAppUserGroupRepository : IRepository<AppUserGroup>
    {
    }
    public class AppUserGroupRepository : RepositoryBase<AppUserGroup>, IAppUserGroupRepository
    {
        public AppUserGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
