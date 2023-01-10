using FirmOrders.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirmOrders.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private List<Order> Orders = new()
        {
            new(1,1,1,"Serkan ISIK",new DateTime(2023, 10, 25)),
            new(2,1,3,"Durdu ISIK",new DateTime(2023, 10, 29)),
            new(3,1,3,"Emine ISIK",new DateTime(2023, 10, 29)),
            new(4,1,5,"Aysegül ISIK",new DateTime(2023, 10, 29)),
            new(5,2,11,"Hakan ISIK",new DateTime(2023, 10, 25)),
            new(6,2,12,"Nurcan ISIK",new DateTime(2023, 10, 29)),
            new(7,2,15,"Emine ISIK",new DateTime(2023, 10, 29)),
            new(8,2,14,"Aysegül ISIK",new DateTime(2023, 10, 29)),
        };

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var order = Orders.Find(o => o.Id == id);

            if (order is not null)
            {
                return Ok(order);
            }

            return NotFound("Firm not found");

        }

        [HttpGet("List")]
        public ActionResult List()
        {
            return Ok(Orders);
        }

    }
}
