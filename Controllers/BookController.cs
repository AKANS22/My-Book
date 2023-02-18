using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Book.Data.Services;
using My_Book.Data.ViewModel;

namespace My_Book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BookServices _bookService;

        public BooksController(BookServices bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book) 
        { 
           _bookService.AddBook(book);
            return Ok();
        }
        
        [HttpGet ("Get-All-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _bookService.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpGet("Get-book-by-id/{id}")]
        public IActionResult GetBookById(int id) 
        { 
              var SigleBook = _bookService.GetABookById(id);
            return Ok(SigleBook);
        }

    }
}
