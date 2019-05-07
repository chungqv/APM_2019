using System;

namespace APM.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        APMDBContext Init();
    }
}