using System.ComponentModel.DataAnnotations;

namespace FormsApp_SatisProjesi.Models
{
    public class Product
    {

        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        //Required ise yaramasi icin bos deger alamayan bir prop gerekli
        //ornegin fiyat bos gelirse 0 degerini alir.
        [Required]
        [Display(Name = "Urun Adi")]
        public string? Name { get; set; } 


        [Required(ErrorMessage = "Alan bos gecilemez")]// Turkcelestirme 
        [Range(0,100000)] //aralik icin kontrol
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        
        [Display(Name = "Resim")]
        public string Image { get; set; } 


        public bool IsActive { get; set; }


        [Display(Name="Category")]
        [Required]
        public int CategoryId { get; set; }
    }
}
