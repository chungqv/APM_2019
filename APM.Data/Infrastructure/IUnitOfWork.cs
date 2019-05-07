namespace APM.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}