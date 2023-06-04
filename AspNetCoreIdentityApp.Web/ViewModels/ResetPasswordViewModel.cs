using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class ResetPasswordViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz!")]
        [Display(Name = "Yeni Şifre :")]
        public string? Password { get; set; }


        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifreler aynı değildir.")]
        [Required(ErrorMessage = "Şifre Tekrar alanı boş bırakılamaz!")]
        [Display(Name = " Yeni Şifre Tekrar :")]
        public string? PasswordConfirm { get; set; }
    }
}
