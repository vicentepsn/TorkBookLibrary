using BookLibrary.Api.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Api.Infrastructure.Repositories
{
    public class BookRepository : RepositoryWithIdBase<Book>, IBookRepository
    {
        protected DbSet<Book> BookDbSet { get; }
        private readonly IUnitOfWork _unitOfWork;


        public BookRepository(IUnitOfWork unitOfWork, BookLibraryDbContext context) : base(context)
        {
            _unitOfWork = unitOfWork;
            BookDbSet = context.Set<Book>();
        }

        public IEnumerable<Book> GetAll()
        {
            return BookDbSet;
        }

        public IEnumerable<Book> GetAllThatMatch(Book bookAsParameter)
        {
            throw new NotImplementedException();
        }
    }
}
