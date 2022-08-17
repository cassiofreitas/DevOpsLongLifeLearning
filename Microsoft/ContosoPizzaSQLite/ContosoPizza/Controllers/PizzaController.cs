using ContosoPizza.Services;
using ContosoPizza.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    PizzaService _service;

    public PizzaController(PizzaService service)
    {
        _service = service;
    }

    /// <summary>
    /// Returns a list of all Pizzas.
    /// </summary>
    /// <returns>A list of Pizzas.</returns>
    /// <remarks>
    /// 
    ///     There is no filter, so API returns a full list of Pizzas, even if it is an empty list.
    ///
    ///     Sample request:
    ///
    ///         GET /pizza
    /// 
    /// </remarks>
    /// <response code="200">Returns the Pizza list.</response>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [HttpGet]
    public IEnumerable<Pizza> GetAll()
    {
        return _service.GetAll();
    }

    /// <summary>
    /// Returns one Pizza detail, based on Pizza.id.
    /// </summary>
    /// <param name = "id">Pizza id</param>
    /// <returns>Details about an specific pizza.</returns>
    /// <remarks>
    /// 
    ///     There is a filter (id), so API returns details about the filtered Pizza id.
    ///
    ///     Sample request:
    ///
    ///         GET /pizza/N  => where N is the Pizza.id
    /// 
    /// </remarks>
    /// <response code="200">Returns details of Pizza based on id.</response>
    /// <response code="404">Returns NotFound if there is no Pizza with the received id.</response>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id}")]
    public ActionResult<Pizza> GetById(int id)
    {
        var pizza = _service.GetById(id);

        if (pizza is not null)
        {
            return pizza;
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Creates a new Pizza.
    /// </summary>
    /// <param name = "newPizza">A Pizza Object</param>
    /// <returns>Details about the created pizza.</returns>
    /// <remarks>
    /// 
    ///     Creates a new Pizza, based on the received JSON details
    ///
    ///     Sample request:
    ///
    ///         POST /pizza
    /// 
    /// </remarks>
    /// <response code="201">Returns details of the created Pizza.</response>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [Consumes("application/json")]
    [HttpPost]
    public IActionResult Create(Pizza newPizza)
    {
        var pizza = _service.Create(newPizza);
        return CreatedAtAction(nameof(GetById), new { id = pizza!.Id }, pizza);
    }

    /// <summary>
    /// Adds a Toppings list to an specific Pizza
    /// </summary>
    /// <param name = "id">A Pizza id</param>
    /// <param name = "toppingId">A Topping id</param>
    /// <returns>No content or a not found</returns>
    /// <remarks>
    /// 
    ///     Adds a Toppings list to an specific Pizza, based on Pizza.id
    ///
    ///     Sample request:
    ///
    ///         PUT /pizza/N/addtopping     =>  where N is the Pizza.id
    /// 
    /// </remarks>
    /// <response code="204">Returns No Content if the operation was OK.</response>
    /// <response code="404">Returns Not Found if there is no Pizza with the received id.</response>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpPut("{id}/addtopping")]
    public IActionResult AddTopping(int id, int toppingId)
    {
        var pizzaToUpdate = _service.GetById(id);

        if (pizzaToUpdate is not null)
        {
            _service.AddTopping(id, toppingId);
            return NoContent();
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Adds a Sauce to an specific Pizza
    /// </summary>
    /// <param name = "id">A Pizza id</param>
    /// <param name = "sauceId">A Sauce id</param>
    /// <returns>No content or a not found</returns>
    /// <remarks>
    /// 
    ///     Adds a Sauce to an specific Pizza, based on Pizza.id
    ///
    ///     Sample request:
    ///
    ///         PUT /pizza/N/updatesauce =>  where N is the Pizza.id
    /// 
    /// </remarks>
    /// <response code="204">Returns No Content if the operation was OK.</response>
    /// <response code="404">Returns Not Found if there is no Pizza with the received id.</response>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpPut("{id}/updatesauce")]
    public IActionResult UpdateSauce(int id, int sauceId)
    {
        var pizzaToUpdate = _service.GetById(id);

        if (pizzaToUpdate is not null)
        {
            _service.UpdateSauce(id, sauceId);
            return NoContent();
        }
        else
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Deletes an specific Pizza
    /// </summary>
    /// <param name = "id">A Pizza id</param>
    /// <returns>OK or not found</returns>
    /// <remarks>
    /// 
    ///     Deletes an specific Pizza, based on Pizza.id
    ///
    ///     Sample request:
    ///
    ///         DELETE /pizza/N =>  where N is the Pizza.id
    /// 
    /// </remarks>
    /// <response code="200">Returns OK if the operation was OK.</response>
    /// <response code="404">Returns Not Found if there is no Pizza with the received id.</response>
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = _service.GetById(id);

        if (pizza is not null)
        {
            _service.DeleteById(id);
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}