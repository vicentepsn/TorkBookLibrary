using BookLibrary.Api.Infrastructure.Entities;

namespace BookLibrary.Api.Infrastructure.Repositories
{
    public interface IBookRepository: IRepositoryWithIdBase<Book>
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetAllThatMatch(Book bookAsParameter);
    }
}
