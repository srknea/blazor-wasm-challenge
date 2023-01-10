using FirmOrders.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrders.Shared
{
    public class Firm : BaseEntity
    {
        //prop + 2*Tab
        public string FirmaAdi { get; set; } = null!;
        public bool OnayDurumu { get; set; }
        public DateTime SiparisIzinBaslangicTarihi { get; set; }
        public DateTime SiparisIzinBitisTarihi { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        // //ctor + 2*Tab
        public Firm()
        {
                
        }

        public Firm(int Id, string FirmaAdi, bool OnayDurumu, DateTime SiparisIzinBaslangicTarihi, DateTime SiparisIzinBitisTarihi)
        {
            this.Id = Id;
            this.FirmaAdi = FirmaAdi;   
            this.OnayDurumu = OnayDurumu;
            this.SiparisIzinBaslangicTarihi = SiparisIzinBaslangicTarihi;
            this.SiparisIzinBitisTarihi = SiparisIzinBitisTarihi;
        }


    }
}
