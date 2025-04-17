
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class BasketDetails
    {
        public int Id_Product { get; set; }
        public int Id_Basket { get; set; }
        public Products Products { get; set; }
        public Basket Basket { get; set; }

    }
}