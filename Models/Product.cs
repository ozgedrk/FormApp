using System.ComponentModel.DataAnnotations;

namespace FormApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Display(Name = "Kitap Adi")]
        [Required(ErrorMessage = "Kitap Adi Girilmek Zorunda!")]
        [StringLength(120, ErrorMessage = "Kitap Adi Maksimum 120 Karakterden Olusmalidir!")]
        public string? BookName { get; set; } = null;

        [Display(Name = "Sayfa")]
        [Required]
        [Range(0, 1500)]
        public int? PageCount { get; set; }

        [Display(Name = "Gorsel")]
        public string? Image { get; set; } = string.Empty;

        [Display(Name = "Aktiflik")]
        public bool IsActive { get; set; }

        [Display(Name = "Kategori Id")]
        [Required]
        public int? CategoryId { get; set; }
        // public IFormFile ImageFile { get; set; }
    }
}

