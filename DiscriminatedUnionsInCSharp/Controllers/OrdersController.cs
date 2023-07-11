using DiscriminatedUnionsInCSharp.Models;
using DiscriminatedUnionsInCSharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DiscriminatedUnionsInCSharp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrdersService _ordersService;
    public OrdersController(IOrdersService ordersService)
    {
        _ordersService = ordersService;
    }
    [HttpPost]
    public IActionResult Post(Order order)
    {
        var placeOrderResult = _ordersService.PlaceOrder(order);
        return placeOrderResult.Match<IActionResult>(
            receipt => Ok(receipt),
            error => StatusCode(500, new { error = error.ToString() }));
    }
}
