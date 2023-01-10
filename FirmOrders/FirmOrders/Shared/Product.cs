using FirmOrders.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrders.Shared
{
    public class Product : BaseEntity
    {
        public int FirmId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Firm Firm { get; set; }

        public Product()
        {

        }

        public Product(int Id, int FirmId, string Name, int Stock, long Price)
        {
            this.Id = Id;
            this.FirmId = FirmId;
            this.Name = Name;
            this.Stock = Stock;
            this.Price = Price;
        }

    }
}
