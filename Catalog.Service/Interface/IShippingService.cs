using Catalog.Service.DTO;

namespace Catalog.Service.Interface
{
    public interface IShippingService
    {
        ShippingDTO GetBookShippingCost(int bookId);
    }
}
