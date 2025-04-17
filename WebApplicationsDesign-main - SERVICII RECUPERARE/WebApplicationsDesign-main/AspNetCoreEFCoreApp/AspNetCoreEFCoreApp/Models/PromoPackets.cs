using System.ComponentModel.DataAnnotations;
namespace AspNetCoreEFCoreApp.Models
{
    public class PromoPackets
    {
        [Key]
        public int Id_Product { get; set; }
        [Display(Name = "Tip Pachet Promotional")]
        public string ProductName { get; set; }
        [Display(Name = "Descriere ")]
        public string Description { get; set; }
        [Display(Name = "Pret ")]
        public int Price_Packet { get; set; }
        [Display(Name = "Imagine Pachet")]
        public string Photo_Pack { get; set; }
        [Display(Name = "Tip pachet")]
        public string Type_Pack { get; set; }
        public ICollection<PromoPackets_Products>? PromoPackets_Products { get; set; }
    }
}