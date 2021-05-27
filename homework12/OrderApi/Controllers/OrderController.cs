using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly ILogger<OrderController> _logger;
        private readonly OrdingDBContext _ctx;

        public OrderController(ILogger<OrderController> logger, OrdingDBContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return new OrderService(_ctx).QueryAll();
        }
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            var r = new OrderService(_ctx).GetOrder(id);
            if(r == null)
            {
                return NotFound();
            }
            return r;
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                new OrderService(_ctx).DeleteOrder(id);
                return Ok("删除成功");
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public bool AddOrUpdate(Order order)
        {
            return new OrderService(_ctx).AddOrder(order);
        }
    }
}
