using LibraAPI.Communications.Requests;
using LibraAPI.Communications.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        var response = new Book
        {
            Id = 1,
            Gender = Book.GenderEnum.Aventura,
            Author = "J.R.R Tolkien",
            Title = "Hobbit",
            qty = 10,
            price = 39.99
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof (Book), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(Book), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestCreateBookJson request) {

        var response = new ResponseCreateBookJson
        {
            Id = 1,
            Title = request.Title,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Book), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id,[FromBody] RequestUpdateBook request)
    {

        var response = new ResponseUpdateBookJson
        {
            Id = id,
            Title = request.Title,
            Gender=request.Gender,
            Author = request.Author,
            Qty= request.qty,
            Price = request.price
        };

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(Book), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }
}
