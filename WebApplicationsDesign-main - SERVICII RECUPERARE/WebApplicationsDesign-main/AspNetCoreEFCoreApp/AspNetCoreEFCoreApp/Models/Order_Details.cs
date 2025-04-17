
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class Order_Details
    {
        public int Id_Order { get; set; }
        public int Id_Product { get; set; }
        public Orders Orders { get; set; }
        public Products Products { get; set; }



    }
}