using System.ComponentModel.DataAnnotations;

namespace HastaneRandevu.MVC.Models.DTOs
{
    public class HastaCreateDTO
    {
        [Required(AllowEmptyStrings =false, ErrorMessage= "Ad Alani Zorunludur.")]
        public string HastaAdi { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Soyad Alani Zorunludur.")]
        public string HastaSoyadi { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Cinsiyet Alani Zorunludur.")]
        public string? Cinsiyeti { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Cinsiyet Alani Zorunludur.")]
        [MaxLength(11, ErrorMessage = "TcNo 11 Karakterden fazla Olmamalidir")]
        [MinLength(11, ErrorMessage = "TcNo 11 Karakterden az Olmamalidir")]
        public string HastaTcNo { get; set; }
    }
}
