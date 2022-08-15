using ContosoPizza.Data;
using ContosoPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class CouponController : ControllerBase
{
    PromotionsContext _context;
    public CouponController(PromotionsContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Returns a list of all Coupons.
    /// </summary>
    /// <returns>A list of coupons.</returns>
    /// <remarks>
    /// 
    ///     There is no filter, so API returns a full list of Coupons, even if it is an empty list.
    ///
    ///     Sample request:
    ///
    ///         GET /coupon
    /// 
    /// </remarks>
    /// <response code="200">Returns the Coupons list.</response>
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<Coupon> Get()
    {
        return _context.Coupons
            .AsNoTracking()
            .ToList();
    }
}