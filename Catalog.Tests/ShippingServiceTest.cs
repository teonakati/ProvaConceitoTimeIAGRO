using Catalog.Repository;
using Catalog.Repository.Interface;
using Catalog.Service;
using Catalog.Service.DTO;
using Catalog.Service.Interface;

namespace Catalog.Tests
{
    public class ShippingServiceTest
    {
        private Context _context;
        private IBookRepository _bookRepository;
        private IShippingService _shippingService;

        public ShippingServiceTest()
        {
            _context = new Context(@"../../../../Catalog.API/Json/books.json");
            _bookRepository = new BookRepository(_context);
            _shippingService = new ShippingService(_bookRepository);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ShouldNotEvaluateBookShippingCost(int bookId)
        {
            var shippping = _shippingService.GetBookShippingCost(bookId);

            Assert.Null(shippping);
        }

        [Theory]
        [InlineData(1)]
        public void ShouldEvaluateBookShippingCost(int bookId)
        {
            var bookPercentage = 0.2;
            var expectedCost = _bookRepository.GetById(bookId).Price * bookPercentage;

            var shippping = _shippingService.GetBookShippingCost(bookId);

            Assert.Equal(expectedCost, shippping.Cost);
        }
    }
}
