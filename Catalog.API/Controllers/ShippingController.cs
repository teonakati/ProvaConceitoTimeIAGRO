using Catalog.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private IShippingService _shippingService;

        public ShippingController(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }

        /// <summary>
        /// Calcula o valor do frete de acordo com o livro informado
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        [HttpGet("book/{bookId}")]
        public IActionResult BookShipping(int bookId)
        {
            var shipping = _shippingService.GetBookShippingCost(bookId);

            if (shipping == null) return NotFound("Não foi encontrado nenhum livro para cálculo de frete.");

            return Ok(shipping);
        }
    }
}
