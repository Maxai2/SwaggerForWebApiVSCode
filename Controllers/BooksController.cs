using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class BooksController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(string[]), 200)] // (return, in case)
    public IActionResult Get()
    {
        return Ok(new[] 
        {
            "Book1",
            "Book2",
            "Book3"
        });
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public ActionResult<Book> Get(int id) // ActionResult типизированный и позволяет уточнить что надо вернуть
    {
        return new Book
        {
            Year = 2018,
            Genre = "For kids",
            Pages = 1488,
            Author = "QWERTY",
            Title = "Mein Kampf",
            Id = 1
        };
    }
}