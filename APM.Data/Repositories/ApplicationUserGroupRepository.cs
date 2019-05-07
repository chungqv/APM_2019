using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APM.Data.Infrastructure;
using APM.Entity.Models;

namespace APM.Data.Repositories
{
    public interface IUserGroupRepository : IRepository<UserGroup>
    {

    }
    public class UserGroupRepository : RepositoryBase<UserGroup>, IUserGroupRepository
    {
        public UserGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
