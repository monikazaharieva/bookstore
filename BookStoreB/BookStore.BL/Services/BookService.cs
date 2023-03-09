using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Data;
using BookStore.Models.Request;

namespace BookStore.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void Add(AddBookRequest book)
        {
            var book = new Book()
            {
                Id = _bookRepository.GetAll()
                .OrderByDescending(x:Book => x.Id)
                .FirstOrDefault().Id+1,
                Description = AddBookRequest.
            }
        }

        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }
    }
}