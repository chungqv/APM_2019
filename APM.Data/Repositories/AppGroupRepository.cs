using APM.Data.Infrastructure;
using APM.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM.Data.Repositories
{
        public interface IAppGroupRepository : IRepository<AppGroup>
        {
        }
        public class AppGroupRepository : RepositoryBase<AppGroup>, IAppGroupRepository
        {
            public AppGroupRepository(IDbFactory dbFactory) : base(dbFactory)
            {
            }
        }
}
