using BookLibrary.Api.Infrastructure.Entities;

namespace BookLibrary.Api.Infrastructure.Repositories
{
    public interface IRepositoryWithIdBase<TEntity> where TEntity : EntityWithIdBase
    {
        void Add(TEntity obj);
        Task<TEntity> GetById(int id);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void AddOrUpdate(TEntity obj);
    }
}
