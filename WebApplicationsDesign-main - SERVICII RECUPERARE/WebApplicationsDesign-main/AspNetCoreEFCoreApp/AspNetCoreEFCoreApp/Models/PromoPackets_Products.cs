
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class PromoPackets_Products
    {   // table PromoPackets_Products from many to many between PromoPackets and Products

        public int Id_Packet { get; set; }
        public int Id_Product { get; set; }
        public Products Products { get; set; }
        public PromoPackets PromoPackets { get; set; }

    }
}
