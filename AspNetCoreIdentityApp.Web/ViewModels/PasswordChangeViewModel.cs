using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class PasswordChangeViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz!")]
        [Display(Name = "Şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalı.")]
        public string PasswordOld { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Yeni şifre alanı boş bırakılamaz!")]
        [Display(Name = "Yeni şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalı.")]
        public string PasswordNew { get; set; } = null!;

        [DataType(DataType.Password)]
        [Compare(nameof(PasswordNew), ErrorMessage = "Şifreler aynı değildir.")]
        [Required(ErrorMessage = "Yeni şifre tekrar alanı boş bırakılamaz!")]
        [Display(Name = "Yeni şifre tekrar :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalı.")]
        public string PasswordConfirm { get; set; } = null!;
    }
}
