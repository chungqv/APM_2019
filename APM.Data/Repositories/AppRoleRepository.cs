using APM.Data.Infrastructure;
using APM.Entity.Models;

namespace APM.Data.Repositories
{
    public interface IAppRoleRepository : IRepository<AppRole>
    {
    }
    public class AppRoleRepository : RepositoryBase<AppRole>, IAppRoleRepository
    {
        public AppRoleRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
