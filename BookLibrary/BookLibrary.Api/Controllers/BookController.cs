using Microsoft.AspNetCore.Mvc;
using BookLibrary.Api.DTO;
using BookLibrary.Api.Services;
using BookLibrary.Api.Services.Exceptions;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpPut()]
        public IActionResult Put([FromBody] BookDTO book)
        {
            try
            {
                var result = _bookService.AddNewBook(book);
                return Ok(result);
            }
            catch (HttpResponseException ex)
            {
                return StatusCode(ex.Status, ex.Value);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            try
            {
                var result = _bookService.GetBook(id);
                return Ok(result);
            }
            catch (HttpResponseException ex)
            {
                return StatusCode(ex.Status, ex.Value);
            }
        }

        [HttpGet()]
        public IActionResult Get([FromBody] BookSearchParameters searchParameters)
        {
            try
            {
                var result = _bookService.ListBook(searchParameters);
                return Ok(result);
            }
            catch (HttpResponseException ex)
            {
                return StatusCode(ex.Status, ex.Value);
            }
        }
    }
}
