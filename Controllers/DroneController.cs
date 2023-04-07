using DroneCalculationWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DroneCalculationWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DroneController : ControllerBase
{
    //private readonly MyDbContext _context;

    //public ProductsController(MyDbContext context)
    public DroneController()
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

