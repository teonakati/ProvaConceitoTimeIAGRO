using Catalog.Domain.Models;
using Catalog.Service.DTO;

namespace Catalog.Service.Interface
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks(BookFilterDTO filters);
    }
}
