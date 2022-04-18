using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="İsim giriniz")]
        [MyFirstVal]
        [Display(Name="İsim")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyisim giriniz")]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Tel giriniz")]
        [Display(Name = "Tel")]
        [StringLength(10,MinimumLength =10,ErrorMessage ="telefon 10 haneli olmalıdır")]
        [PhoneValidation]
        public string Phone { get; set; }
    }
}
