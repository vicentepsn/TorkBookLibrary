namespace BookLibrary.Api.Infrastructure.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();

        void CleanupChanges();
    }
}
