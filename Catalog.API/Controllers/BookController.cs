using Catalog.Service.DTO;
using Catalog.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        /// <summary>
        /// Retorna uma lista de livros com possibilidade de inclusão de filtros
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetBooks([FromQuery] BookFilterDTO filters)
        {
            return Ok(_bookService.GetBooks(filters));
        }
    }
}
