using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Api.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookLibraryDbContext _context;

        public UnitOfWork(BookLibraryDbContext context)
        {
            _context = context;
        }

        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _context.Database.RollbackTransaction();
        }
        public void CleanupChanges()
        {
            foreach (var dbEntityEntry in _context.ChangeTracker.Entries().ToList())
            {

                if (dbEntityEntry.Entity != null)
                {
                    dbEntityEntry.State = EntityState.Detached;
                }
            }
        }

    }
}
