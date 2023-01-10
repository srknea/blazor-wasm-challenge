using FirmOrders.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirmOrders.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> Products = new()
        {
            new(1,1,"Bere",865, 75),
            new(2,1,"Kaban",465, 875),
            new(3,1,"Pijama",865, 75),
            new(4,1,"Tişort",865, 75),
            new(5,1,"Şort",865, 75),
            new(6,1,"Parfüm",865, 75),
            new(6,1,"Yüzük",865, 75),
            new(7,1,"Çanta",865, 75),
            new(8,1,"Atkı",865, 75),
            new(9,1,"Gömlek",865, 75),
            new(10,1,"Çeket",865, 75),
            new(11,2,"Şişman Tüp",865, 75),
            new(12,2,"Uzun Tüp",865, 75),
            new(13,2,"Piknik Tüpü",865, 75),
            new(14,2,"Ticari Tüp",865, 75),
            new(15,2,"Forklift Tüp",865, 75),
            
        };

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var product = Products.Find(o => o.Id == id);

            if (product is not null)
            {
                return Ok(product);
            }

            return NotFound("Product not found");

        }

        [HttpGet("List")]
        public ActionResult List()
        {
            return Ok(Products);
        }
    }
}
