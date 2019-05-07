using APM.Data.Infrastructure;
using APM.Entity.Models;

namespace APM.Data.Repositories
{
    public interface IAppRoleGroupRepository : IRepository<AppRoleGroup>
    {
    }
    public class AppRoleGroupRepository : RepositoryBase<AppRoleGroup>, IAppRoleGroupRepository
    {
        public AppRoleGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
