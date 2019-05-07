using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APM.Data.Infrastructure;
using APM.Entity.Models;

namespace APM.Data.Repositories
{
    public interface IRoleRepository : IRepository<AppRole>
    {
        IEnumerable<AppRole> GetListRoleByGroupId(int groupId);
    }
    public class RoleRepository : RepositoryBase<AppRole>, IRoleRepository
    {
        public RoleRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<AppRole> GetListRoleByGroupId(int groupId)
        {
            var query = from g in DbContext.Roles
                        join ug in DbContext.RoleGroups
                        on g.Id equals ug.RoleId
                        where ug.GroupId == groupId
                        select g;
            return query;
        }
    }
}
