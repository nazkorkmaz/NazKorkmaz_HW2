using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Comment
    {
        public int Id{ get; set; }
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Detail { get; set; }
        [Display(Name = "Değerlendirme")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int? Rating { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; }

        public int BookId { get; set; }
        [Display(Name = "Kitap İsmi")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public Book Book { get; set; }
        public Comment()
        {
            CreatedDate = DateTime.Now;
            
        }
    }
}
