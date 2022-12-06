using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FileSharingSite.Models
{
    public class MemberViewModel
    {
        public int Id { get; set; }

        // Creating necessary validations for each form field

        [Display(Name = "İsim")]
        [Required(ErrorMessage = "İsim alanı zorunludur!")]
        [RegularExpression("([a-zA-Z',.-]+( [a-zA-Z',.-]+)*){2,30}", ErrorMessage = "Geçersiz giriş! Lütfen tekrar deneyiniz.")]
        public string Name { get; set; }

        [Display(Name = "E-posta")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "E-posta alanı zorunludur!")]
        [RegularExpression("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$", ErrorMessage = "Geçersiz giriş! Lütfen geçerli bir E-posta adresi giriniz.")]
        public string Email { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı zorunludur!")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Geçersiz Şifre! Şifreniz; en az bir büyük harf, bir karakter ve bir sayı dahil olmak üzere 8 karakterden oluşmalıdır.")]
        public string Password { get; set; }
    }
}