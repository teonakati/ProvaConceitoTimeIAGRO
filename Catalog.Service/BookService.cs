using Catalog.Domain.Models;
using Catalog.Repository.Interface;
using Catalog.Service.DTO;
using Catalog.Service.Interface;

namespace Catalog.Service
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository { get; }
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetBooks(BookFilterDTO filters)
        {
            var books = _bookRepository.GetBooks();

            if (filters == null) 
                return books;

            if (filters.Id.HasValue) 
                books = books.Where(x => x.Id == filters.Id);

            if (filters.Price.HasValue) 
                books = books.Where(x => x.Price == filters.Price);

            if (!string.IsNullOrEmpty(filters.Name)) 
                books = books.Where(x => x.Name.ToLower().Contains(filters.Name.ToLower()));

            if (filters.Specifications is not null)
            {
                if (filters.Specifications.OriginallyPublished.HasValue) 
                    books = books.Where(x => x.Specifications.OriginallyPublished == filters.Specifications.OriginallyPublished);

                if (filters.Specifications.PageCount.HasValue) 
                    books = books.Where(x => x.Specifications.PageCount == filters.Specifications.PageCount);

                if (!string.IsNullOrEmpty(filters.Specifications.Author)) 
                    books = books.Where(x => x.Specifications.Author.ToLower().Contains(filters.Specifications.Author.ToLower()));

                if (!string.IsNullOrEmpty(filters.Specifications.Illustrator)) 
                    books = books.Where(x => x.Specifications.Illustrator.Any(ill => ill.ToLower().Contains(filters.Specifications.Illustrator.ToLower())));

                if (!string.IsNullOrEmpty(filters.Specifications.Genre)) 
                    books = books.Where(x => x.Specifications.Genres.Any(genre => genre.ToLower().Contains(filters.Specifications.Genre.ToLower())));
            }

            if (!string.IsNullOrEmpty(filters.Ordering))
            {
                if (filters.Ordering.ToLower().Contains("asc"))
                    books = books.OrderBy(x => x.Price);

                if (filters.Ordering.ToLower().Contains("desc"))
                    books = books.OrderByDescending(x => x.Price);
            }

            return books;
        }
    }
}
