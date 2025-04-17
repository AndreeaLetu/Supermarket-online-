
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class Products
    {
        [Key]
        public int Id_Product { get; set; }
        public string Name_Product { get; set; }
        public int Price_Product { get; set; }
        public string Image_Product { get; set; }
        public string Description_Product { get; set; }
        public int Id_Categories { get; set; }
        public Categories? Categories { get; set; }
        public ICollection<Order_Details>? Order_Details { get; set; }
        public ICollection<BasketDetails>? BasketDetails { get; set; }
        public ICollection<PromoPackets_Products>? PromoPackets_Products { get; set; }



    }
}