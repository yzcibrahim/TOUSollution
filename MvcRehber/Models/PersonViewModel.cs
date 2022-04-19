using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRehber.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim giriniz")]
        [Display(Name = "İsim")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyisim giriniz")]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Tel giriniz")]
        [Display(Name = "Tel")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "telefon 10 haneli olmalıdır")]
        public string Phone { get; set; }
    }
}
