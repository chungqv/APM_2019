using APM.Data;

namespace APM.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private APMDBContext dbContext;

        public APMDBContext Init()
        {
            return dbContext ?? (dbContext = new APMDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}