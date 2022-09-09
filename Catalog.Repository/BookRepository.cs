using Catalog.Domain.Models;
using Catalog.Repository.Interface;

namespace Catalog.Repository
{
    public class BookRepository : IBookRepository
    {
        private Context _context;

        public BookRepository(Context context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }

        public Book GetById(int id)
        {
            return _context.Books.Find(x => x.Id == id);
        }
    }
}
