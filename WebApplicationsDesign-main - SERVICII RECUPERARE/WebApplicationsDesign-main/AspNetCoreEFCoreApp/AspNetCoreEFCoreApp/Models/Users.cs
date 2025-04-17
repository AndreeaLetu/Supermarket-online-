
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class Users
    {
        [Key]
        public int CNP { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string Email { get; set; }
        public DateTime born_date { get; set; }

        public string Password { get; set; }

        //1 to many relationship with feedback
        public ICollection<Feedback> Feedbacks { get; set; }
        //1 to many relationship with Orders
        public ICollection<Orders> Orders { get; set; }



    }
}