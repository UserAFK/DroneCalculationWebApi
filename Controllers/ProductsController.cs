using DroneCalculationWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DroneCalculationWebApi.Controllers;

[Route("api/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    //private readonly MyDbContext _context;

    //public ProductsController(MyDbContext context)
    public ProductsController()
    {
        // _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
    {
        // var products = await _context.Products
        //     .Select(p => new ProductDto { Id = p.Id, Name = p.Name })
        //     .ToListAsync();
        var products = new List<ProductDto>()
        {
            new(){Id=1,Name="apple"},
            new(){Id=2,Name="watermellon"},
        };
        return products;
    }
}

