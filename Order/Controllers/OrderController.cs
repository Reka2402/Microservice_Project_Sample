using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Order.Data;
using Order.Models;

namespace Order.Controllers
{
    [ApiController]
    [Route("api/Orders")]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext _context;
        public OrderController(OrderDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<OrderModel>> AddOrder(OrderModel Order)
        {
            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOrders), new { id = Order.Id }, Order);
        }
    }
}
