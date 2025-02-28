using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product.Data;
using Product.Models;

namespace Product.Controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _context;
        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ProductModel>> AddProduct(ProductModel Product)
        {
            _context.Products.Add(Product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProducts), new { id = Product.Id }, Product);
        }
    }
}
