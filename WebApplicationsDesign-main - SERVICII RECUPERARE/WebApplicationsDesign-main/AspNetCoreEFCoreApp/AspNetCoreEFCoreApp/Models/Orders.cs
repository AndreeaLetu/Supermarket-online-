
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class Orders
    {
        [Key]
        public int Id_Order { get; set; }
        public int Total_Price { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int CNP_Client { get; set; } // FK from User 
        public Basket Basket { get; set; }  // Relația 1 la 1 cu Basket

        public Users Users { get; set; } // 1 to many relationship with Users
        public ICollection<Order_Details> Order_Details { get; set; }



    }
}