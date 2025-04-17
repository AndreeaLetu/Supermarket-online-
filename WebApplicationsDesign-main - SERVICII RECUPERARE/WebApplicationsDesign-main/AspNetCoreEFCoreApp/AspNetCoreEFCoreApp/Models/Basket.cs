
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class Basket
    {
        [Key]
        public int Id_Basket { get; set; }
        public int Quantity { get; set; }
        public int Total_Price { get; set; }
        public Orders Orders { get; set; }
        public ICollection<BasketDetails> BasketDetails { get; set; }


    }
}