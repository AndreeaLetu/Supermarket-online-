
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class Categories
    {
        [Key]
        public int Id_Categories { get; set; }
        public string Name_Categories { get; set; }
        public string Description { get; set; }

        public ICollection<Products> Products { get; set; }

    }
}