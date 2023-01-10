using FirmOrders.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirmOrders.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FirmController : ControllerBase
    {
        private List<Firm> Firms = new()
        {
            new(1,"Koton",true,new DateTime(2023, 10, 25), new DateTime(2023, 12, 2)),
            new(2,"İpragaz",true,new DateTime(2023, 10, 25), new DateTime(2023, 12, 2)),

        };

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var firm = Firms.Find(o => o.Id == id);

            if (firm is not null)
            {
                return Ok(firm);
            }

            return NotFound("Firm not found");

        }

        [HttpGet("List")]
        public ActionResult List()
        {
            return Ok(Firms);
        }
    }
}
