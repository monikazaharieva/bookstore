using BookStore.BL.Interfaces;
using BookStore.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Book> GetAll()
        {
            return _bookService.GetAll();
        }

        [HttpGet("GetById")]
        public Book GetById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Book book)
        {
            _bookService.AddBook(book);
        }

        [HttpDelete("Delete")]
        public void Delete(int bookId)
        {
            _bookService.DeleteBook(bookId);
        }
    }
}