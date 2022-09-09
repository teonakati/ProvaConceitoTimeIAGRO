using Catalog.Repository.Interface;
using Catalog.Service.DTO;
using Catalog.Service.Interface;

namespace Catalog.Service
{
    public class ShippingService : IShippingService
    {
        private IBookRepository _bookRepository;

        public ShippingService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public ShippingDTO GetBookShippingCost(int bookId)
        {
            var book = _bookRepository.GetById(bookId);

            if (book == null) return null;

            var bookPercentage = 0.2;

            return new ShippingDTO() { Cost = Math.Round(book.Price * bookPercentage, 2) };

        }
    }
}
