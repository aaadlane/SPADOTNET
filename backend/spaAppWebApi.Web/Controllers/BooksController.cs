using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace spaAppWebApi.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/api/books")]
        public ActionResult GetBooks()
        {
return Ok("books");
        }
    }
}
