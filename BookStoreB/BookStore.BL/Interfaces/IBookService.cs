using BookStore.Models.Data;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);

        void AddBook(Book book);

        void DeleteBook(int id);
    }
}