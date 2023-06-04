using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Ad alanı boş bırakılamaz!")]
        [Display(Name = "Kullanıcı adı :")]
        public string? UserName { get; set; }

        [EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz!")]
        [Display(Name = "Email :")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz!")]
        [Display(Name = "Telefon :")]
        public string? Phone { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz!")]
        [Display(Name = "Şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalı.")]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifreler aynı değildir.")]
        [Required(ErrorMessage = "Şifre Tekrar alanı boş bırakılamaz!")]
        [Display(Name = "Şifre Tekrar :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalı.")]
        public string? PasswordConfirm { get; set; }
    }
}
