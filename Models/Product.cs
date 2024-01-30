using System.ComponentModel.DataAnnotations;

namespace FormsApp_SatisProjesi.Models
{
    public class Product
    {
        [Display(Name = "URUN ID")]
        public int ProductId { get; set; }
        [Display(Name = "URUN ADI")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "FIYAT")]
        public decimal Price { get; set; }
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
    }
}
