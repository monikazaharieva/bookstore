using BookStore.Models.Data;

namespace BookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);

        void AddBook(Book book);

        void DeleteBook(int id);
    }
}