using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(){
            return Ok(await _context.Product.ToListAsync());
        }

        [HttpGet("{id}")] 
        public async Task<IActionResult> GetProduct(long id){
            return Ok(await _context.Product.FindAsync(id));
        }
    }
}