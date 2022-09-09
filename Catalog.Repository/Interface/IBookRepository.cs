using Catalog.Domain.Models;

namespace Catalog.Repository.Interface
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetById(int id);
    }
}
