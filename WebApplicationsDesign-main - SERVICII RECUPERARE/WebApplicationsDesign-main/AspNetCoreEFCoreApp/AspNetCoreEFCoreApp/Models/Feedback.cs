
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class Feedback
    {
        [Key]
        public int Id_Feedback { get; set; }
        public string Name_Full { get; set; }
        public string Photo { get; set; }
        public string Message { get; set; }

        //relationship 1 to many with Users
        public int CNP { get; set; }
        public Users? Users { get; set; }
    }
}