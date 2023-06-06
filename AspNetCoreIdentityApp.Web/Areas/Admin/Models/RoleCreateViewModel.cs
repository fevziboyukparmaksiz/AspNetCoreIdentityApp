using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.Areas.Admin.Models
{
    public class RoleCreateViewModel
    {
        [Required(ErrorMessage = "Role ismi boş bırakılamaz")]
        [Display(Name = "Rol ismi: ")]
        public string? Name { get; set; }
    }
}
