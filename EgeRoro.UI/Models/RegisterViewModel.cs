
using System.ComponentModel.DataAnnotations;

namespace EgeRoro.UI.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "UserName alanı zorunludur.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }
    }

}
