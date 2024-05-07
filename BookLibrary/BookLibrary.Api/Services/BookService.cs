using BookLibrary.Api.DTO;
using AutoMapper;
using BookLibrary.Api.Infrastructure.Repositories;
using BookLibrary.Api.Infrastructure.Entities;

namespace BookLibrary.Api.Services
{
    public class BookService : IBookService
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;

        public BookService(IMapper mapper, IBookRepository bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public async Task<BookDTO> AddNewBook(BookDTO book)
        {
            Book bookEntity = _mapper.Map<Book>(book);
            _bookRepository.Add(bookEntity);
        }

        public async Task<BookDTO> GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookDTO>> ListBook(BookSearchParameters searchParameters)
        {
            throw new NotImplementedException();
        }
    }
}
