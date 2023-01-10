using FirmOrders.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrders.Shared
{
    public class Order : BaseEntity
    {
        public int FirmId { get; set; }
        public int ProductId { get; set; }
        public string? SiparisVerenKisiAdi { get; set; }
        public DateTime SiparisTarihi { get; set; }

        public Firm Firm { get; set; }
        public Product Product { get; set; }

        public Order()
        {

        }

        public Order(int Id, int FirmId, int ProductId, string SiparisVerenKisiAdi, DateTime SiparisTarihi)
        {
            this.Id = Id; 
            this.FirmId = FirmId;
            this.ProductId = ProductId; 
            this.SiparisVerenKisiAdi = SiparisVerenKisiAdi;
            this.SiparisTarihi = SiparisTarihi; 
        }
    }
}
