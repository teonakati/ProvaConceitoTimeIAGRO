using Catalog.Repository;
using Catalog.Service;
using Catalog.Service.DTO;
using Catalog.Service.Interface;

namespace Catalog.Tests
{
    public class BookServiceTest
    {
        private IBookService _bookService;

        public BookServiceTest()
        {
            _bookService = new BookService(new BookRepository(new Context(@"../../../../Catalog.API/Json/books.json")));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ShouldNotReturnBooks(int bookId)
        {
            var filter = new BookFilterDTO { Id = bookId };
            var countExpected = 0;
            
            var books = _bookService.GetBooks(filter);

            Assert.Equal(countExpected, books.Count());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(null)]
        public void ShouldReturnBooks(int? bookId)
        {
            var filter = new BookFilterDTO { Id = bookId };

            var books = _bookService.GetBooks(filter);

            Assert.True(books.Count() > 0);
        }

    }
}