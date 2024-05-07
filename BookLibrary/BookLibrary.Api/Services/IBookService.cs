using BookLibrary.Api.DTO;
using BookLibrary.Domain;

namespace BookLibrary.Api.Services
{
    public interface IBookService
    {
        Task<BookDTO> AddNewBook(BookDTO book);
        Task<BookDTO> GetBook(int id);
        Task<IEnumerable<BookDTO>> ListBook(BookSearchParameters searchParameters);
    }
}